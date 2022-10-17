using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ClassWork_CSharp17._10._2022
{
    internal class Program
    {
        static IEnumerable<char> myReverse(IEnumerable<char> text, char match)
         //static string myReverse(string text, char match)
        {
            foreach (var item in text.Reverse()) //LINQ Reverse
            {
                Console.Write(" " + item);
            }
            int number = (from c in text
                          where c == match
                          select c).Count();
            Console.WriteLine($"В Строке \"{text}\" насчитано {number} совпадений с " +
                $"\"{match}\"");
            return text.Reverse<char>();
            //return text.Reverse<char>().ToString();
        }
        static void FindMatches(string text, char match)
        {

            int number = (from c in text
                          where c == match select c).Count();
            Console.WriteLine($"В Строке \"{text}\" насчитано {number} совпадений с " +
                $"\"{match}\"");
        }
        static string Uniq(string text)
        {
            string _result = "";
            foreach (var item in text.Distinct<char>())
            {
                Console.Write(" " + item);
                _result += item;
            }
            Console.WriteLine();
            return _result;
        }
        static string nextSing(IEnumerable<char> text)
        {
            string _result = "";
            for(int i = 0; i < text.Count(); i++)
            {

            }
            Console.WriteLine();
            return _result;
        }
        static void Main(string[] args)
        {
           /* Years year = new Years();
            foreach (var month in year)
            {
                Console.WriteLine(month);
            }*/

            
            //Console.WriteLine("Введите строку: ");
            //IEnumerable<char> tmp = Console.ReadLine();
            //string tmp = Console.ReadLine();
            /*Console.WriteLine("Введите символ для поиска: ");
            char ch = Console.ReadLine()[0];
            myReverse(tmp, ch);*/

            //Console.WriteLine("Введите строку для поиска: ");
            //string search = Console.ReadLine();
            //Uniq(search);
            /*foreach (var item in Uniq(search))
            {
                FindMatches(tmp, item);
            }*/

            //Uniq(tmp);

            Zodiac zodiacs = new Zodiac();
            foreach (var zodiacSigns in zodiacs)
            {
                Console.WriteLine(zodiacSigns);
            }
        }
    }
}
