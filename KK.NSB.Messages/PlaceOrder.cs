using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
namespace KK.NSB.Messages
{
    public class PlaceOrder : ICommand
    {
        public string Product { get; set; }
    }

}
