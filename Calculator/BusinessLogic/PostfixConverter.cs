using System.Collections.Generic;

namespace BusinessLogic
{
    public class PostfixConverter:IConverter
    {
        private readonly IValidator _validator;
        private readonly IOperationProvider _operationProvider;

        public PostfixConverter(IValidator validator, IOperationProvider operationProvider)
        {
            _validator = validator;
            _operationProvider = operationProvider;
        }


        public string Convert(string infixString)
        {
            if (string.IsNullOrEmpty(infixString))
            {
                return null;
            }

            if (!_validator.IsValid(infixString))
            {
                return null;
            }

            var output = string.Empty;
            Stack<char> operStack = new Stack<char>();

            for (int i = 0; i < infixString.Length; i++) 
            {
                if (" ".IndexOf(infixString[i]) != -1)
                    continue; 

                //Если символ - цифра, то считываем все число
                if (char.IsDigit(infixString[i]))
                {
                    while (!(" ".IndexOf(infixString[i]) != -1) && !_operationProvider.IsOperation(infixString[i]))
                    {
                        output += infixString[i];
                        i++;

                        if (i == infixString.Length) break;
                    }

                    output += " ";
                    i--;
                }

                //Если символ - оператор
                if (_operationProvider.IsOperation(infixString[i]))
                {
                    if (infixString[i] == '(')
                        operStack.Push(infixString[i]);
                    else if (infixString[i] == ')')
                    {
                        char s = operStack.Pop();

                        while (s != '(')
                        {
                            output += s.ToString() + ' ';
                            s = operStack.Pop();
                        }
                    }
                    else 
                    {
                        if (operStack.Count > 0) 
                            if (_operationProvider.GetOperation(infixString[i]).GetPriority <= _operationProvider.GetOperation(operStack.Peek()).GetPriority) 
                                output += operStack.Pop() + " ";

                        operStack.Push(char.Parse(infixString[i].ToString()));

                    }
                }
            }
            
            while (operStack.Count > 0)
                output += operStack.Pop() + " ";

            return output; 
        }
    }
}