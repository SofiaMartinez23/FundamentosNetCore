namespace FundamentosNetCore
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form06ValidarMail());
            //Application.Run(new Form05Char());
            //Application.Run(new Form04DateTime());
            //Application.Run(new Form03DiaNacimiento());
            //Application.Run(new Form02PosicionColores());
            //Application.Run(new Form01SumaNumeros());
            //Application.Run(new Form1());
        }
    }
}