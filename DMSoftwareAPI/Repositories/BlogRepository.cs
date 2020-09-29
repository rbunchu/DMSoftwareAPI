using System;
using System.Collections.Generic;
using DMSoftwareAPI.Models.Data;
using DMSoftwareAPI.Repositories.Interfaces;
using MongoDB.Driver;

namespace DMSoftwareAPI.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly string _collection = "blogposts";
        private readonly IMongoContext _context;

        public BlogRepository(IMongoContext context)
        {
            this._context = context;
        }

        public void AddPost(BlogPost post)
        {
            var collection = _context.Database.GetCollection<BlogPost>(this._collection);
            collection.InsertOne(post);
        }

        public BlogPost GetPost(Guid Id)
        {
            var collection = _context.Database.GetCollection<BlogPost>(this._collection);
            var filter = Builders<BlogPost>.Filter.Eq(element => element.ID, Id);

            return collection.Find(filter).Single();
        }

        public List<BlogPost> ListPosts(int top)
        {
            var collection = _context.Database.GetCollection<BlogPost>(this._collection);
            return collection.Find(element => true).Limit(10).ToList();
        }

        public void RemovePost(Guid Id)
        {
            var collection = _context.Database.GetCollection<BlogPost>(this._collection);
            var filter = Builders<BlogPost>.Filter.Eq(element => element.ID, Id);
            collection.FindOneAndDelete(filter);
        }

        public void UpdatePost(Guid Id, BlogPost post)
        {
            RemovePost(Id);
            AddPost(post);
        }
    }
}
