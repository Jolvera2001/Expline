using Expline.Models.Domain;
using LiteDB;

namespace Expline.Services;

class TransactionService
{
    private readonly DbContextService _DbContext;
    private readonly LiteDatabase _database;

    public TransactionService(DbContextService dbContext)
    {
        _DbContext = dbContext;
        _database = _DbContext.GetDatabase();
    }

    public IEnumerable<RecurringTransaction> GetRecurringTransactionsAsync()
    {
        var collection = _database.GetCollection<RecurringTransaction>("recurring_transactions");
        return collection.FindAll().ToList();
    }
}
