using Honest.Timesheet.DbMigrator;

namespace App
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
            DbMigrator.Migrate("Data Source=.\\Data.db");
            Application.Run(new Main());
        }
    }
}