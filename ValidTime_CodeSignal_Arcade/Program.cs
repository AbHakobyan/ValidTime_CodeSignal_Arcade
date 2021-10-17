using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidTime_CodeSignal_Arcade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "00:00";
            bool y = validTime(s);
            Console.WriteLine(y);
        }

        static bool validTime(string time)
        {
            string[] text = time.Split(':');
            int x = 0;
            int y = 0;
            bool t = false;
            if (Convert.ToInt32(text[0]) >= 0 && Convert.ToInt32(text[0]) <= 23 && Convert.ToInt32(text[1]) >= 0 && Convert.ToInt32(text[1]) <= 59)
            {
                t = true;
            }
            else
                t = false;
            return t;
        }
    }
}
