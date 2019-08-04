using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            char charA = 'A';
            char charZ = 'Z';
            for (int i = charZ; i >=charA ; i--)
                Console.WriteLine(Convert.ToChar(i));
            Console.Read();
        }
    }
}
