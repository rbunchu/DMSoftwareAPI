using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DMSoftwareAPI.Models
{
    public class Contact
    {
        [BsonId]
        [BsonElement("id")]
        [BsonRepresentation(MongoDB.Bson.BsonType.String)]
        public Guid ID { get; set; }
        [BsonElement("fullname")]
        public string FullName { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("content")]
        public string Content { get; set; }
        [BsonElement("submitted")]
        [BsonRepresentation(MongoDB.Bson.BsonType.DateTime)]
        public DateTime Submitted { get; set; }
        [BsonElement("asnwered")]
        [BsonRepresentation(MongoDB.Bson.BsonType.Boolean)]
        public bool Answered { get; set; }
    }
}
