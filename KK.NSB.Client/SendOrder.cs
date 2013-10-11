using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KK.NSB.Messages;
using NServiceBus;

namespace KK.NSB.Client
{
    public class SendOrder :IWantToRunWhenBusStartsAndStops
    {
        public IBus Bus { get; set; }
        public void Start()
        {
            Bus.Send("Server", new PlaceOrder() {Product = "New Shoes"});
        }

        public void Stop()
        {
            throw new NotImplementedException();
        }
    }
}
