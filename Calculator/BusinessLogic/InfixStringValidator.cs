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
                if (char.IsDigit(c) || _operationProvider.IsOperation(c) || char.IsWhiteSpace(c) || c.Equals('(') || c.Equals(')'))
                {
                    continue;
                }
                return false;
            }

            return true;
        }
    }
}