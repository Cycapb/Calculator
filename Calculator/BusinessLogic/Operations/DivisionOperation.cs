namespace BusinessLogic.Operations
{
    public class DivisionOperation:IOperation
    {
        public int GetPriority => 4;
        public decimal Execute(decimal x, decimal y)
        {
            throw new System.NotImplementedException();
        }
    }
}