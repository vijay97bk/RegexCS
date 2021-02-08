using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
        Regex firstnameregex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        Regex lastNameregex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        Regex emailIdregex = new Regex(@"^[A-Za-z]{3}[.]([a-zA-Z]{3})*[bl.co][.in]*");
        Regex mobileNumberregex = new Regex(@"^[1-9]{2}[][1-9]1{0}$");
        public void FirstNameValidation(string firstName)
        {
            Console.WriteLine("first name"+ firstName);
            if (firstnameregex.IsMatch(firstName))
                Console.WriteLine("Valid first name ");
            else
                Console.WriteLine("first name is not valid");
        }
        public void lastNameValidation(string lastName)
        {
            Console.WriteLine("last name" + lastName);
            if (lastNameregex.IsMatch(lastName))
                Console.WriteLine("Valid last name ");
            else
                Console.WriteLine("last name is not valid");
        }
        public void emailIdValidation(string emailId)
        {
            Console.WriteLine("EmailId" + emailId);
            if (emailIdregex.IsMatch(emailId))
                Console.WriteLine("Valid email id ");
            else
                Console.WriteLine("email id is not valid");
        }
        public void mobileNumberValidation(string mobileNumber)
        {
            Console.WriteLine("mobile number" + mobileNumber);
            if (emailIdregex.IsMatch(mobileNumber))
                Console.WriteLine("Valid number ");
            else
                Console.WriteLine("number id is not valid");
        }

        public static void Main(string[] args)
        {
            Program person = new Program();
            string firstName = "Vijay";
            person.FirstNameValidation(firstName);

            string lastName = "Kshirasagar";
            person.lastNameValidation(lastName);

            string emailId = "abc@bl.co.in";
            person.emailIdValidation(emailId);

            string mobileNumber = "91 9900422544";
            person.mobileNumberValidation(mobileNumber);
        }

           
    }
}
