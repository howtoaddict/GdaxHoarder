using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdaxHoarder.Data.Entities
{
    public class BurdenLog
    {
        public int BurdenLogId { get; set; }
        public string BurdenLogName { get; set; }
        public DateTime Created { get; set; }
        [BsonRef("burdens")]
        public int BurdenId { get; set; }
    }
}
