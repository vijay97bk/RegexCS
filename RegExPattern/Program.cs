﻿using System;
using System.Text.RegularExpressions;

namespace RegExPattern
{
    class Program
    {
        /// <summary>
        /// regex pattern for all UC
        /// </summary>
        Regex firstnameregex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        Regex lastNameregex = new Regex(@"^[A-Z][A-Za-z]{2,}$");
        Regex emailIdregex = new Regex(@"^[a-z]{3}([.,+,-,][a-zA-Z0-9]{3})*[a-z][.][a-z]{2}$");
        Regex mobileNumberregex = new Regex(@"^[1-9]{2}[][1-9]1{0}$");
        Regex passwordregex = new Regex(@"^[A-Z][A-Za-z1-9]{5}[@,-,$,*][0-1]$");
        /// <summary>
        /// first name validation UC1
        /// </summary>
        /// <param name="firstName"></param>
        public void FirstNameValidation(string firstName)
        {
            
            Console.WriteLine("first name"+ firstName);
            if (firstnameregex.IsMatch(firstName))
                Console.WriteLine("Valid first name ");
            else
                Console.WriteLine("first name is not valid");
        }
        /// <summary>
        /// last name validation UC4
        /// </summary>
        /// <param name="lastName"></param>
        public void lastNameValidation(string lastName)
        {
            Console.WriteLine("last name" + lastName);
            if (lastNameregex.IsMatch(lastName))
                Console.WriteLine("Valid last name ");
            else
                Console.WriteLine("last name is not valid");
        }
        /// <summary>
        /// email id validation UC3
        /// </summary>
        /// <param name="emailId"></param>
        public void emailIdValidation(string emailId)
        {
            Console.WriteLine("EmailId" + emailId);
            if (emailIdregex.IsMatch(emailId))
                Console.WriteLine("Valid email id ");
            else
                Console.WriteLine("email id is not valid");
        }
        /// <summary>
        /// mobile number validation UC4
        /// </summary>
        /// <param name="mobileNumber"></param>
        public void mobileNumberValidation(string mobileNumber)
        {
            Console.WriteLine("mobile number" + mobileNumber);
            if (emailIdregex.IsMatch(mobileNumber))
                Console.WriteLine("Valid number ");
            else
                Console.WriteLine("number is not valid");
        }
        /// <summary>
        /// password validation UC5,6,7,8
        /// </summary>
        /// <param name="password"></param>
        public void passwordValidation(string password)
        {
            Console.WriteLine("password " + password);
            if (passwordregex.IsMatch(password))
                Console.WriteLine("Valid password ");
            else
                Console.WriteLine("password is not valid");
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

            string password = "abc@123";
            person.passwordValidation(password);
        }

           
    }
}
