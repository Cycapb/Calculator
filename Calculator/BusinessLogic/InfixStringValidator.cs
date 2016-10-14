using System;
using System.Linq;

namespace BusinessLogic
{
    public class InfixStringValidator:IValidator
    {
        public bool IsValid(string inputString)
        {

            if (inputString.Any(char.IsLetter))
            {
                return false;
            }
            throw new NotImplementedException();            
        }
    }
}