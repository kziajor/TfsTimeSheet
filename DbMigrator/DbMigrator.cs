using DbUp;

namespace Honest.Timesheet.DbMigrator;

public static class DbMigrator
{
    public static void Migrate(string connectionString)
    {
        var migratorBuilder = DeployChanges.To
           .SQLiteDatabase(connectionString)
           .WithTransaction()
           .WithScriptsEmbeddedInAssemblies(new[]
           {
               typeof(DbMigrator).Assembly
           },
           (s) => s.StartsWith("Honest.Timesheet.DbMigrator.MigrationScripts."));

#if DEBUG
        migratorBuilder.LogToConsole();
#else
        migratorBuilder.LogToNowhere();
#endif

        var engine = migratorBuilder.Build();

        if (!engine.IsUpgradeRequired()) { return; }

        engine.PerformUpgrade();
    }
}