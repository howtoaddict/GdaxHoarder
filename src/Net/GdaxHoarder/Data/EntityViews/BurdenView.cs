using GdaxHoarder.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdaxHoarder.Data.EntityViews
{
    public class BurdenView
    {
        public BurdenView(Burden burden)
        {
            Task = burden.ToString();
            NextRunTime = burden.NextRunTime;
        }

        public string Task { get; set; }
        public DateTime NextRunTime { get; set; }
    }
}
