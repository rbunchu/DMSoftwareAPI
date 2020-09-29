using MongoDB.Driver;

namespace DMSoftwareAPI.Repositories.Interfaces
{
    public interface IMongoContext
    {
        IMongoDatabase Database { get; }
    }
}
