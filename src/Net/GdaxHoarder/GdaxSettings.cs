using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoinbaseExchange.NET.Core;

namespace GdaxHoarder
{
    public class GdaxSettings
    {
        public string PassPhrase { get; set; }
        public string ApiKey { get; set; }
        public string SecretKey { get; set; }
        public bool IsSandbox { get; set; }

        public static GdaxSettings Parse(string relativeFilePath)
        {
            var lines = File.ReadAllLines(relativeFilePath);

            var set = new GdaxSettings
            {
                PassPhrase = lines[0],
                ApiKey = lines[1],
                SecretKey = lines[2],
                IsSandbox = String.Compare(lines[3], "SANDBOX", true) == 0
            };

            return set;
        }

        public CBAuthenticationContainer ToAuthContainer()
        {
            return new CBAuthenticationContainer(ApiKey, PassPhrase, SecretKey);
        }
    }
}
