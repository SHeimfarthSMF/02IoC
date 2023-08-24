using Ninject;

namespace IoCApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var kernel = new StandardKernel(new IoC());


            ApplicationConfiguration.Initialize();
            Application.Run(kernel.Get<Registration>());
        }
    }
}