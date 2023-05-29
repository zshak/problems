using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problems
{
    public class MainClass
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string color= Console.ReadLine();

            Color.Print(input, Convert.ToInt32(color));

        }
    }
}
