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
            throw new System.NotImplementedException();
        }
    }
}