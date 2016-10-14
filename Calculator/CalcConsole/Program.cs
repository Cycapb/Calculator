using System;
using BusinessLogic;
using Ninject;

namespace CalcConsole
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input expression:");
            var exp = Console.ReadLine();
            Console.WriteLine($"Result: {Calculate(exp)}");
            Console.ReadLine();
        }

        private static decimal Calculate(string inputString)
        {
            var kernel = GetKernel();
            var calculator = kernel.Get<Calculator>();
            return calculator.Calculate(inputString);
        }

        private static IKernel GetKernel()
        {
            var kernel = new StandardKernel();
            kernel.Bind<Calculator>().ToSelf();
            kernel.Bind<IExecuter>().To<SimpleExecuter>();
            kernel.Bind<IValidator>().To<InfixStringValidator>();
            kernel.Bind<IOperationProvider>().To<SimpleOperationProvider>();
            kernel.Bind<IConverter>().To<PostfixConverter>();
            return kernel;
        }
    }
}
