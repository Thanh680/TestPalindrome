using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeApp
{
    public class Palindrome
    {
        private String chaineNormale;

        public Palindrome()
        {
            this.chaineNormale = "";
        }
        public Boolean verifierPalindrome(String chaine)
        {
            if ((chaine.Any(char.IsLower) && !(chaine.Any(char.IsDigit))) ||
                (chaine.Any(char.IsUpper) || chaine.Any(char.IsLower)) ||
                (chaine.Contains("*é,è,à*")) ||
                (chaine.Any(char.IsPunctuation)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    // Exécution du Programme
    class Program
    {

        static void Main(string[] args)
        {
            String laChaine = "";
            Console.WriteLine("Saisissez une phrase :");
            laChaine = Console.ReadLine();
            Palindrome monPal = new Palindrome();
            if (monPal.verifierPalindrome(laChaine))
            {
                Console.WriteLine("c'est un palindrome");
            }
            else
            {
                Console.WriteLine("ce n'est pas un palindrome");
            }
            Console.ReadKey();

        }
    }
}
