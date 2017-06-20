using GdaxHoarder.Data.EntityTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GdaxHoarder.Data.Entities
{
    // Was thinking to name it Task, but it's too generic, so I went with Burden
    // Sounds cute, but dunno if it'll stick long term or
    // code reviews will determine it was shitty name
    public class Burden
    {
        public int BurdenId { get; set; }
        public BurdenType BurdenTypeId { get; set; }
        public GdaxCurrency BurdenTypeCurrency { get; set; }
        public string WalletAddr { get; set; }
        public decimal BurdenTypeAmount { get; set; }
        public DateTime NextRunTime { get; set; }
        public RepeatUnits RepeatUnit { get; set; }
        public int RepeatValue { get; set; }

        public int RepeatTotalSeconds
        {
            get
            {
                if (RepeatUnit <= RepeatUnits.Hour)
                {
                    var multiplier = Math.Pow(60, (int)RepeatUnit - 1);
                    return (int)(multiplier * RepeatValue);
                }
                else if (RepeatUnit == RepeatUnits.Day)
                {
                    return RepeatValue * 3600;
                }

                return 0;
            }
        }

        public override string ToString()
        {
            if (BurdenTypeId == BurdenType.DepositAch)
                return String.Format("Deposit ${0} through ACH", BurdenTypeAmount);
            else if (BurdenTypeId == BurdenType.BuyCurrency)
                return String.Format("Buy {0} for ${1}", BurdenTypeCurrency, BurdenTypeAmount);
            else if (BurdenTypeId == BurdenType.WithdrawToWallet)
            {
                if (BurdenTypeAmount <= 0)
                    return String.Format("Withdraw all {0} to {1}", BurdenTypeCurrency, WalletAddr);
                else
                    return String.Format("Withdraw {0} {1} to {2}", 
                        BurdenTypeAmount, BurdenTypeCurrency, WalletAddr);
            }

            return base.ToString();
        }

        public static DateTime CalcNextRuntime(DateTime dateTime, RepeatUnits unit, int val)
        {
            if (unit == RepeatUnits.Second)
                return dateTime.AddSeconds(val);
            else if(unit == RepeatUnits.Minute)
                return dateTime.AddMinutes(val);
            else if (unit == RepeatUnits.Hour)
                return dateTime.AddHours(val);
            else if (unit == RepeatUnits.Day)
                return dateTime.AddDays(val);
            else
                return DateTime.MaxValue;
        }
    }
}
