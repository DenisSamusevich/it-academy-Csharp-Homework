using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW08.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string DeleteMaxWord(string strChange)
            {
                int indexMaxString = 1;
                char rowSeparator = ' ';
                int indexSimbolMax = 0;
                StringBuilder deleteWord;

                foreach (char simbol in strChange)
                    if (simbol == rowSeparator)
                        indexMaxString += 1;
                string[] word = new string[indexMaxString];
                word = strChange.Split(rowSeparator);
                for (int i = 0; i < word.Length; i++)
                    if (word[i].Length > word[indexSimbolMax].Length)
                        indexSimbolMax = i;
                if (indexSimbolMax == 0)
                {
                    deleteWord = new StringBuilder(word[indexSimbolMax]);
                    deleteWord.Append(rowSeparator);
                }
                else
                {
                    deleteWord = new StringBuilder(rowSeparator.ToString());
                    deleteWord.Append(word[indexSimbolMax]);
                }
                strChange = strChange.Replace(deleteWord.ToString(),string.Empty);
                return strChange;
            }

            string SwapMaxMinWord(string strChange)
            {
                int indexMaxString = 1;
                char rowSeparator = ' ';
                int indexSimbolMax = 0;
                int indexSimbolMin = 0;
                string wordSwap = String.Empty;

                foreach (char simbol in strChange)
                    if (simbol == rowSeparator)
                        indexMaxString += 1;
                string[] word = new string[indexMaxString];
                word = strChange.Split(rowSeparator);
                for (int i = 0; i < word.Length; i++)
                    if (word[i].Length > word[indexSimbolMax].Length)
                        indexSimbolMax = i;
                for (int i = 0; i < word.Length; i++)
                    if (word[i].Length < word[indexSimbolMin].Length)
                        indexSimbolMin = i;
                wordSwap = word[indexSimbolMax];
                word[indexSimbolMax] = word[indexSimbolMin];
                word[indexSimbolMin] = wordSwap;
                strChange = string.Join(" ",word);
                return strChange;
            }

            string MaxSimbolsOrPunctuations(string strChange, bool simbolsOrPunctuation)
            {
                string result = String.Empty;
                char simbolA = 'A';
                char simbola = 'a';
                char simbolZ = 'Z';
                char simbolz = 'z';
                int simbolMax = 0;
                int punctuationMax = 0;
                char[] punctuation = new char[11] { '!', '\"', '\'', '(', ')',',','-','.',':',';','?' };
                foreach (char simbol in strChange)
                {
                    if ((simbol >= simbolA && simbol <= simbolZ) || (simbol >= simbola && simbol <= simbolz))
                        simbolMax += 1;
                    for (int i = 0; i < punctuation.Length; i++)
                        if (simbol == punctuation[i])
                            punctuationMax += 1;
                }
                if (simbolsOrPunctuation)
                    return result = "Maximum number of characters = " + simbolMax.ToString();
                else
                    return result = "Maximum number of punctuation marks = " + punctuationMax.ToString();
            }
            string[] FastSortWordString(string strSort)
            {
                string result = String.Empty;
                int indexMaxString = 0;
                char rowSeparator = ' ';
                int indexSimbol = 0;
                int indexMoreMax = 0;
                int indexLessMax = 0;
                string moreWords = String.Empty;
                string lessWords = String.Empty;
                foreach (char simbol in strSort)
                    if (simbol == rowSeparator)
                        indexMaxString += 1;
                if (indexMaxString == 0)
                {
                    string[] resultat = new string[1];
                    return resultat;
                }
                else
                {
                    string[] wordLess = new string[indexMaxString + 1];
                    string[] wordMore = new string[indexMaxString + 1];
                    string[] word = new string[indexMaxString + 1];
                    word = strSort.Split(rowSeparator);
                    for (int i = 1; i < word.Length; i++)
                    {

                        if (word[i].Length < word[indexSimbol].Length)
                        {
                            wordLess[indexLessMax] = word[i];
                            indexLessMax += 1;
                        }
                        else
                            wordMore[indexMoreMax] = word[i];
                        indexMoreMax += 1;
                    }
                    string[] sortWordLess = new string[indexLessMax];
                    string[] sortWordMore = new string[indexMoreMax];
                    for (int i = 0; i < sortWordLess.Length; i++)
                        sortWordLess[i] = wordLess[i];
                    for (int i = 0; i < sortWordMore.Length; i++)
                        sortWordMore[i] = wordMore[i];
                    string[] resultat = new string[indexMaxString + 1];
                    return resultat = (FastSortWordString(string.Join(" ", sortWordLess)) + " " + word[indexSimbol] + " " + FastSortWordString(string.Join(" ", sortWordMore))).Split(' ');

                }
                
            }        

            string strText = "Подход хорошо подходит для интернета ведь допустимое значение длины описания сниппета может изменятся поэтому главное чтобы наиболее важная часть следовала в самом начале сниппета";
            Console.WriteLine(DeleteMaxWord(strText));
            Console.WriteLine(SwapMaxMinWord(strText));
            Console.WriteLine(MaxSimbolsOrPunctuations(strText, true));
            Console.WriteLine(MaxSimbolsOrPunctuations(strText, false));
            for (int i = 0; i < FastSortWordString(strText).Length; i++)
            {
                Console.WriteLine(FastSortWordString(strText)[i]);
            }
            Console.Read();
        }
    }
}
