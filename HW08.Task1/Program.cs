using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            string poemLine = string.Empty;
            char rowSeparator = ';';
            int indexMaxStringPoem = 1;
            char oldRuo = 'о';
            char oldRuO = 'О';
            char oldEngo = 'o';
            char oldEngO = 'O';
            char newRua = 'а';
            char newRuA = 'А';
            char newEnga = 'a';
            char newEngA = 'A';
            //poemLine = "Я к вам пишу — чего же боле?;Что я могу ещё сказать?;Теперь, я знаю, в вашей воле;Меня презреньем наказать.;Но вы, к моей несчастной доле;Хоть каплю жалости храня,;Вы не оставите меня.";
            poemLine = Console.ReadLine();
            foreach (char simbol in poemLine)
                if (simbol == rowSeparator)
                    indexMaxStringPoem += 1;
            string[] poem = new string[indexMaxStringPoem];
            poem = poemLine.Split(rowSeparator);
            for (int i = 0; i < poem.Length; i++)
            {
                poem[i] = poem[i].Replace(oldRuo, newRua);
                poem[i] = poem[i].Replace(oldRuO, newRuA);
                poem[i] = poem[i].Replace(oldEngo, newEnga);
                poem[i] = poem[i].Replace(oldEngO, newEngA);
                Console.WriteLine(poem[i]);
            }
            Console.Read();

        }
    }
}
