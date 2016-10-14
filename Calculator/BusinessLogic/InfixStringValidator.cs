using System;
using System.Linq;

namespace BusinessLogic
{
    public class InfixStringValidator:IValidator
    {
        private readonly IOperationProvider _operationProvider;

        public InfixStringValidator(IOperationProvider operationProvider)
        {
            _operationProvider = operationProvider;
        }

        public bool IsValid(string inputString)
        {
            foreach (var c in inputString)
            {
                if (char.IsDigit(c) || _operationProvider.IsOperation(c) || " ".IndexOf(c) != -1)
                {
                    continue;
                }
                return false;
            }

            return true;
        }
    }
}