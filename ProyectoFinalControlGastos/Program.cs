using ProyectoFinalControlGastos.Models;

namespace ProyectoFinalControlGastos
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        public static Users logedUser { get; set; }
        public static bool Cambio { get; set; } = false;
        [STAThread]

        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new Login());
        }
    }
}