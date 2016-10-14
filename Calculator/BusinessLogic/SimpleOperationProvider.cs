using System;
using System.Collections.Generic;
using BusinessLogic.Operations;

namespace BusinessLogic
{
    public class SimpleOperationProvider:IOperationProvider
    {
        private readonly IDictionary<char, IOperation> _operations;

        public SimpleOperationProvider()
        {
            _operations = new Dictionary<char, IOperation>
            {
                ['+'] = new AddOperation(),
                ['-'] = new SubtractionOperation(),
                ['*'] = new MultiplicationOperation(),
                ['/'] = new DivisionOperation(),
                ['('] = new LeftBracketOperation(),
                [')'] = new RightBracketOperation()
            };
        }

        public bool IsOperation(char c)
        {
            return _operations.ContainsKey(c);
        }

        public IOperation GetOperation(char c)
        {
            try
            {
                return _operations[c];
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}