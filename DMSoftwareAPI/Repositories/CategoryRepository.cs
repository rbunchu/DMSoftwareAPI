using DMSoftwareAPI.Models;
using DMSoftwareAPI.Models.Data;
using DMSoftwareAPI.Repositories.Interfaces;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace DMSoftwareAPI.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly string _collection = "categories";
        private readonly IMongoContext _context;

        public CategoryRepository(IMongoContext context)
        {
            this._context = context;
        }

        public void AddCategory(Category category)
        {
            var collection = _context.Database.GetCollection<Category>(this._collection);
            collection.InsertOne(category);
        }

        public IEnumerable<Category> GetElements(Pagination data)
        {
            var collection = _context.Database.GetCollection<Category>(this._collection);
            return collection.Find(element => true).Skip(data.Page * data.NumberOfElements).Limit(data.NumberOfElements).ToList();
        }

        public void RemoveCategory(Guid id)
        {
            var collection = _context.Database.GetCollection<Category>(this._collection);
            var filter = Builders<Category>.Filter.Eq(cat => cat.Id, id);
            collection.FindOneAndDelete(filter);
        }
    }
}
