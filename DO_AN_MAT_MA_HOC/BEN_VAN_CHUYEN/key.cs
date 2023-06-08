using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEN_VAN_CHUYEN
{
    [Serializable]
    public class key
    {
        //[BsonRepresentation(BsonType.ObjectId)]
        [BsonId, BsonElement("_id"), BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("name"), BsonRepresentation(BsonType.String)]
        public string name { get; set; }
        [BsonElement("value"), BsonRepresentation(BsonType.String)]
        public string value { get; set; }
        public key(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
