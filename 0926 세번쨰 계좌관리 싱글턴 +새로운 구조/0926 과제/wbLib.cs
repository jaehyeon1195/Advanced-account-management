using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0926_과제
{
    class wbLib
    {
        public static int inputnumber(string msg)
        {
            Console.Write(msg + " : ");
            return int.Parse(Console.ReadLine());
        }

        public static string inputstring(string msg)
        {
            Console.Write(msg + " : ");
            return Console.ReadLine();
        }
    }
}
