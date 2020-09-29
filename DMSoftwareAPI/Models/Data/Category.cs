using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DMSoftwareAPI.Models.Data
{
    public class Category
    {
        [BsonId]
        [BsonElement("id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public Guid Id { get; set; }
        [BsonElement("name")]
        public string Name { get; set; }
    }
}
