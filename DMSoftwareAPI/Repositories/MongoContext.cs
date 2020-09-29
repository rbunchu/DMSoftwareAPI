using DMSoftwareAPI.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace DMSoftwareAPI.Repositories
{
    public class MongoContext : IMongoContext
    {
        public IMongoDatabase Database { get; }

        public MongoContext(IConfiguration configuration)
        {
            var connectionStrings = new ConnectionStringsOptions();
            configuration.GetSection(ConnectionStringsOptions.ConnectionStrings).Bind(connectionStrings);

            var client = new MongoClient(connectionStrings.MongoDb);
            this.Database = client.GetDatabase("dmsoftware");
        }
    }
}
