using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome.check_a_word
{
    internal class Palindrome
    {
        static void Main(string[] args)
        {
            string s, revs = "";
            Console.WriteLine("Enter a word");
            s = Console.ReadLine();
            for (int i = s.Length-1; i >= 0; i--) //string reverse
            {
                revs += s[i].ToString();
            }
            if (revs == s) //checking if a word is a palindrome or not
            {
                Console.WriteLine("Congratulations,that word is a palindrome");
            }
            else
            {
                Console.WriteLine("Sorry,that word is not a palindrome");
            }
            Console.Read();

        }
    }
}
