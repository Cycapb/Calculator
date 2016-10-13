using System;

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

        public decimal Calculate(string infixString)
        {
            var postfixString = _converter.Convert(infixString);

            if (postfixString != null)
            {
                return _executer.Execute(postfixString);
            }
            throw new NotImplementedException();
        }
    }
}