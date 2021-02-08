using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
        Regex firstnameregex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        
        public void FirstNameValidation(string firstName)
        {
            Console.WriteLine("first name"+ firstName);
            if (firstnameregex.IsMatch(firstName))
                Console.WriteLine("Valid first name");
            else
                Console.WriteLine("first name is not valid");
        }
        static void Main(string[] args)
        {
            Program person = new Program();
            string firstName = "Vijay";
            person.FirstNameValidation(firstName);
        }

           
    }
}
