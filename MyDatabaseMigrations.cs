using DatabaseMigrations;

namespace Bart
{
    public class MyDatabaseMigrations
    {
        public MyDatabaseMigrations()
        {
            MigrationManager migrationsManager = new MigrationManager();
            migrationsManager.RunMe();
        }
    }
}