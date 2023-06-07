using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace NGUOI_BAN
{
    class Contract
    {
        [BsonId]
        public int Id { get; set; }
        [BsonElement("Buyer")]
        public string Buyer { get; set; }
        [BsonElement("Seller")]
        public string Seller { get; set; }
        public float sum { get; set; }
        public string chuKyBenBan { get; set; }
        public string chuKyNganHang { get; set; }
        public Contract(string Buyer,string Seller, float sum, string chuKyBenBan, string chuKyNganHang)
        {
            this.Buyer = Buyer;
            this.Seller = Seller;
            this.sum = sum;
            this.chuKyBenBan = chuKyBenBan;
            this.chuKyNganHang = chuKyNganHang;
        }
    }
}
