using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler
{
    public  class MusicEvent
    {
        //  listener - signature must match event and delegate
        public void RegisterEvent(object sender, EventInfo e)
        {
            Console.WriteLine("There is a music concert in " + e.Address);
        }
    }
}
