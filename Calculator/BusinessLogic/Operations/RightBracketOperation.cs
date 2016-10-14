namespace BusinessLogic.Operations
{
    public class RightBracketOperation:IOperation
    {
        public int GetPriority => 1;
        public decimal Execute(decimal x, decimal y)
        {
            throw new System.NotImplementedException();
        }
    }
}