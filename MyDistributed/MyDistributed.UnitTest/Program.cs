using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace MyDistributed.UnitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string key1 = "WT20161212001";
            Console.WriteLine(key1.GetHashCode());
            Console.Read();
        }
    }
}
