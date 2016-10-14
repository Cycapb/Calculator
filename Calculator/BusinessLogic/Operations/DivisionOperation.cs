using System;

namespace BusinessLogic.Operations
{
    public class DivisionOperation:IOperation,IOperationExecuter
    {
        public int GetPriority => 4;
        public decimal Execute(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            return x/y;

        }
    }
}