namespace BusinessLogic
{
    public interface IOperationProvider
    {
        bool IsOperation(char c);
        IOperation GetOperation(char c);
    }
}