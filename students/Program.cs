using System;
using System.Windows.Forms;

namespace students
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Run Migrations
            config.Database.CreateTableDisciplines();
            config.Database.CreateTableCareers();
            config.Database.CreateTableCourse();
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
