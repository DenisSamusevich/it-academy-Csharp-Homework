using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW07.Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char first_element = 'A';
            char last_element = 'Z';
            char[] alphabet = new char[26];
            char[] reverse_alphabet = new char[26];
            for (int i = first_element; i <= last_element; i++)
                alphabet[i - first_element] = (char)i;
            Console.WriteLine(alphabet);
            for (int i = 0, j= alphabet.Length-1; i < alphabet.Length; i++, j--)
                reverse_alphabet[i] = alphabet[j];
            for (int i = 0; i < alphabet.Length; i++)
                alphabet[i] = reverse_alphabet[i];
            Console.WriteLine(alphabet);
            Array.Reverse(alphabet);
            Console.WriteLine(alphabet);
            Console.Read();
        }
    }
}
