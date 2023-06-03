using SystemForm;
using Dormitory_Life_Assistant;
namespace SystemForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Administrator administrator = new Administrator("1", "ţ");
            Student student = new Student();
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Application.Run(new AdminForm(administrator));
        }
    }
}