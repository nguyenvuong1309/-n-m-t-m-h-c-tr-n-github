using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEN_VAN_CHUYEN
{
    class contract
    {
        [BsonElement("CONTRACT")]
        public string CONTRACT { get; set; }
        public contract(string c)
        {
            this.CONTRACT = c;
        }
    }
}
