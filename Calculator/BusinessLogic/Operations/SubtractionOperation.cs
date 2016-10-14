namespace BusinessLogic.Operations
{
    public class SubtractionOperation:IOperation
    {
        public int GetPriority => 3;
        public decimal Execute(decimal x, decimal y)
        {
            throw new System.NotImplementedException();
        }
    }
}