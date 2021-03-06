﻿using System.Collections.Generic;

namespace BusinessLogic
{
    public class SimpleExecuter : IExecuter
    {
        private readonly IOperationProvider _operationProvider;

        public SimpleExecuter(IOperationProvider operationProvider)
        {
            _operationProvider = operationProvider;
        }

        public decimal Execute(string postfixString)
        {
            Stack<decimal> temp = new Stack<decimal>();

            for (int i = 0; i < postfixString.Length; i++)
            {
                if (char.IsDigit(postfixString[i]))
                {
                    string a = string.Empty;

                    while (!char.IsWhiteSpace(postfixString[i]) && !_operationProvider.IsOperation(postfixString[i]))
                    {
                        a += postfixString[i];
                        i++;
                        if (i == postfixString.Length) break;
                    }
                    temp.Push(decimal.Parse(a));
                    i--;
                }

                else if (_operationProvider.IsOperation(postfixString[i]))
                {
                    decimal a = temp.Pop();
                    decimal b = temp.Pop();
                    decimal result = 0;
                    result = _operationProvider.GetOperation(postfixString[i]).Execute(b, a);
                    temp.Push(result);
                }
            }
            return temp.Peek();
        }
    }
}