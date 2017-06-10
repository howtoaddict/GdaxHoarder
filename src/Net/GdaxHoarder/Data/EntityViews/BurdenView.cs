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
            BurdenId = burden.BurdenId;
            NextRunTime = burden.NextRunTime;

            Task = burden.ToString();
        }

        public int BurdenId { get; set; }
        public DateTime NextRunTime { get; set; }

        public string Task { get; set; }
    }
}
