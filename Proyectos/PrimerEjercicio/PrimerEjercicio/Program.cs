namespace PrimerEjercicio
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
            //Application.Run(new Funciones());//ejercicio 1 
            //Application.Run(new FuncionesTexto());//ejercicio 2
            Application.Run(new FuncionesFecha());//ejercicio 3
        }
    }
}