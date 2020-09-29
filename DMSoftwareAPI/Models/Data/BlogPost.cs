using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DMSoftwareAPI.Models.Data
{
    public class BlogPost
    {
        [BsonId]
        [BsonElement("id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public Guid ID { get; set; }
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("published")]
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime Published { get; set; }
        [BsonElement("category")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public Guid Category { get; set; }
        [BsonElement("content")]
        public string Content { get; set; }
        [BsonElement("ImageSrc")]
        public string ImageSrc { get; set; }
    }
}
