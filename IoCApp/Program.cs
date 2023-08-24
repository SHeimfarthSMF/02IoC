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
            ApplicationConfiguration.Initialize();
            Application.Run(new Registration(new RegistrationService(new UserRepository(new DataBaseConnection("Data Source=MyOracleDB;User Id=myUsername;Password=myPassword;Integrated Security=no;")), new MailService())));
        }
    }
}