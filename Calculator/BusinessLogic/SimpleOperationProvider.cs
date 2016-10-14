using System.Collections.Generic;

namespace BusinessLogic
{
    public class SimpleOperationProvider:IOperationProvider
    {
        private readonly IDictionary<char, IOperation> _operations;

        public SimpleOperationProvider()
        {
                
        }

        public bool IsOperation(char c)
        {
            throw new System.NotImplementedException();
        }

        public IOperation GetOperation(char c)
        {
            throw new System.NotImplementedException();
        }
    }
}