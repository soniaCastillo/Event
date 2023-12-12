using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public class EventInfo : EventArgs
    {
        public string Address { get; set; }
        public EventInfo(string address)
        {
            this.Address = address;
        }
    }

}