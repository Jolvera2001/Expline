using System.Collections.ObjectModel;
using System.Data.Common;
using LiteDB;

namespace Expline.Services;

class DbContextService
{
    private readonly LiteDatabase _database;

    public DbContextService()
    {
        var dbPath = Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.LocalApplicationData), 
            "Expline", "expline.db");

        _database = new LiteDatabase(dbPath);
    }

    public LiteDatabase GetDatabase()
    {
        return _database;
    }
}
