using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KK.NSB.Messages;
using NServiceBus;

namespace KK.NSB.Server
{
    public class PlaceOrderHandler : IHandleMessages<PlaceOrder>
    {
        public void Handle(PlaceOrder message)
        {
            Console.WriteLine(@"Order placed :", message);
        }
    }
}
