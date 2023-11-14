using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaVjezba04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upisite dva broja jedan cijeli drugi decimalni ");
            string a = Console.ReadLine();
            int x = Convert.ToInt32(a.Split(' ')[0]);
            decimal y = Convert.ToDecimal(a.Split(' ')[1]);
            Console.WriteLine("prvi broj " + x + "\ndrugi broj " + y);
            Console.ReadKey();
        }
    }
}
