using GdaxHoarder.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdaxHoarder.Data.Validators
{
    public class BurdenValidator
    {
        public Burden Val { get; set; }

        public BurdenValidator(Burden obj)
        {
            Val = obj;
            Errors = new Dictionary<string, string>();
        }

        public Dictionary<string,string> Errors { get; set; }
        public bool ValidateAdd()
        {
            Errors.Clear();

            if (Val.BurdenTypeAmount <= 0)
                Errors.Add("numAmount", "Must be greater than 0");

            if (Val.RepeatTotalSeconds <= 60)
                Errors.Add("numRepeatValue", "Must be 60 seconds or more");

            return Errors.Count == 0; 
        }
    }
}
