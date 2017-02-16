using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Jobs.Simple
{
    public class Example : IExample
    {
        public void Say(string message)
        {
            Console.WriteLine("世界和平,"+ message);
        }
    }
}
