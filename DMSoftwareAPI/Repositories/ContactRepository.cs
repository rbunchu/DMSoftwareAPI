using DMSoftwareAPI.Models;
using DMSoftwareAPI.Repositories.Interfaces;

namespace DMSoftwareAPI.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private readonly string _collection = "contacts";
        private readonly IMongoContext _context;

        public ContactRepository(IMongoContext context)
        {
            this._context = context;
        }

        public void AddContact(Contact contact)
        {
            var collection = this._context.Database.GetCollection<Contact>(_collection);
            collection.InsertOne(contact);
        }
    }
}
