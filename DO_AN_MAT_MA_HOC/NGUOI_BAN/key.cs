using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NGUOI_BAN
{
    [Serializable]
    public class key
    {
        //[BsonRepresentation(BsonType.ObjectId)]
        [BsonId,BsonElement("_id"),BsonRepresentation(BsonType.ObjectId)]
        public string _id { get; set; }
        [BsonElement("name"), BsonRepresentation(BsonType.String)]
        public string name { get; set; }
        [BsonElement("value"),BsonRepresentation(BsonType.String)]
        public string value { get; set; }
        public key(string name, string value)
        {
            this.name = name;
            this.value = value;
        }
    }
}
