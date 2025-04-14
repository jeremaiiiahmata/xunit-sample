using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetworkUtility.Model;

namespace NetworkUtility.Ping
{
    public class NetworkService
    {
        public string SendPing()
        {
            // imagine there's a bunch of functions
            // SearchDNS();
            // BuildPacket();

            return "Success: Ping Sent!";
        }

        public int Addition(int a, int b)
        {
            return a + b;
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int DivideByZero(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Cannot be divided by zero.");


            return a / b;
        }

        public PingResult GetPingResult()
        {
            return new PingResult
            {
                Message = "Ping Complete",
                IsSuccessful = true
            };

        }
    }
}
