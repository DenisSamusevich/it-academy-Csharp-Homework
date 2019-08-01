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
                    string[] result = new string[indexMaxString + 1];
                    result[0] = strSort;
                    return result;
                }
                else
                {
                    string[] wordLess = new string[indexMaxString];
                    string[] wordMore = new string[indexMaxString];
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
                        {
                            wordMore[indexMoreMax] = word[i];
                            indexMoreMax += 1;
                        }
                    }
                    string[] result = new string[indexMaxString + 1];
                    string[] strSortMore = new string[indexMoreMax];
                    string[] strSortLess = new string[indexLessMax];
                    for (int i = 0; i < strSortLess.Length; i++)
                        strSortLess[i] = wordLess[i];
                    for (int i = 0; i < strSortMore.Length; i++)
                        strSortMore[i] = wordMore[i];
                    if (indexLessMax == 1)
                    {
                        result[0] = strSortLess[0];
                    }
                    else if(indexLessMax > 0)
                    {
                        strSortLess = FastSortWordString(string.Join(" ", strSortLess));
                        for (int i = 0; i < indexLessMax; i++)
                            result[i] = strSortLess[i];
                    }
                    result[indexLessMax] = word[indexSimbol];
                    if (indexMoreMax == 1)
                        result[indexLessMax + indexMoreMax] = strSortMore[0];
                    else if (indexMoreMax > 0)
                    {
                        strSortMore = FastSortWordString(string.Join(" ", strSortMore));
                        for (int i = indexLessMax; i < indexLessMax + indexMoreMax; i++)
                            result[i+1] = strSortMore[i - indexLessMax];
                    }
                    return result;
                }
            }
            //string strText = "In summer I like to play outside. In summer I like to go to the seaside. I like to pick up shells, To put them on the shelf. That’s what I like to do sometimes, When it comes the summertime";
            string strText = Console.ReadLine();
            Console.WriteLine(DeleteMaxWord(strText));
            Console.WriteLine(SwapMaxMinWord(strText));
            Console.WriteLine(MaxSimbolsOrPunctuations(strText, true));
            Console.WriteLine(MaxSimbolsOrPunctuations(strText, false));
            string[] strTextSort = new string[FastSortWordString(strText).Length];
            strTextSort = FastSortWordString(strText);
            for (int i = 0; i < strTextSort.Length; i++)
                Console.WriteLine(strTextSort[i]);
            Console.Read();
        }
    }
}
