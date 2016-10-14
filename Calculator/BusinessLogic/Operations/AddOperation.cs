namespace BusinessLogic.Operations
{
    public class AddOperation:IOperation
    {
        public int GetPriority => 2;
        public decimal Execute(decimal x, decimal y)
        {
            return x + y;
        }
    }
}