using System;

namespace BusinessLogic.Exceptions
{
    public class InvalidInputStringException:Exception
    {
        public InvalidInputStringException():base("Invalid input string")
        {
            
        }
    }
}