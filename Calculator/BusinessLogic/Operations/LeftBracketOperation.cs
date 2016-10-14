namespace BusinessLogic.Operations
{
    public class LeftBracketOperation:IOperation
    {
        public int GetPriority => 0;
        public decimal Execute(decimal x, decimal y)
        {
            throw new System.NotImplementedException();
        }
    }
}