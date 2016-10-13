namespace BusinessLogic
{
    public class Calculator
    {
        private readonly IConverter _converter;
        private readonly IExecuter _executer;

        public Calculator(IConverter converter, IExecuter executer)
        {
            _converter = converter;
            _executer = executer;
        }

        public int Calculate(string infixString)
        {
            throw new System.NotImplementedException();
        }
    }
}