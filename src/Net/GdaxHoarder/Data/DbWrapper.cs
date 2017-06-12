using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdaxHoarder.Data
{
    public class DbWrapper
    {
        private static LiteDatabase _db;
        public static LiteDatabase Db
        {
             get
            {
                if (_db == null)
                {
                    var dbPath = AppDomain.CurrentDomain.BaseDirectory + "\\MyData.db";
                    _db = new LiteDatabase(dbPath);
                }

                return _db;
            }
        }

        public static void Dispose()
        {
            if (_db != null)
            {
                _db.Dispose();
                _db = null;
            }
        }
    }
}
