namespace BusinessLogic
{
    public class PostfixConverter:IConverter
    {
        private readonly IValidator _validator;

        public PostfixConverter(IValidator validator)
        {
            _validator = validator;
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
            throw new System.NotImplementedException();
        }
    }
}