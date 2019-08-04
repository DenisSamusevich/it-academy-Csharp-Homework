using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW04.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            char keyUp = 'W';
            char keyDown = 'S';
            char keyRight = 'D';
            char keyLeft = 'A';
            char backspace = '\b';
            char direction;

            while (true)
            {
                
                ConsoleKeyInfo keyInfoDirection = Console.ReadKey();
                Console.Write(backspace);
                direction = char.ToUpper(keyInfoDirection.KeyChar);
                if (direction == keyUp)
                    Console.WriteLine("Move up");
                else if (direction == keyRight)
                    Console.WriteLine("Move right");
                else if (direction == keyDown)
                    Console.WriteLine("Move down");
                else if (direction == keyLeft)
                    Console.WriteLine("Move left");
                else
                    Console.WriteLine("Not move");
            }
        }
    }
}
