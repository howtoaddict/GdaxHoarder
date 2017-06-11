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
        public string BurdenName { get; set; }
        public bool Success { get; set; }

        public override string ToString()
        {
            //var table = db.GetCollection<Burden>();
            //var burden = table.FindById(BurdenLogId);

            var format = String.Format("{0} | {1} | {2} | {3}", Created, BurdenName, Success, BurdenLogName);
            return format;
        }
    }
}
