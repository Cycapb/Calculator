namespace BusinessLogic
{
    public interface IOperation
    {
        int GetPriority { get; }
        decimal Execute(decimal x, decimal y);
    }
}