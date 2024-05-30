using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class CustomException : ApplicationException
    {
        public CustomException()
        {
            Console.WriteLine("Custome Exception");
        }
        public class InvalidNameException : CustomException
        {
            public InvalidNameException()
            {
                Console.WriteLine("Please enter correct name");
            }
        }
        public class InvalidAddressException : CustomException
        {
            public InvalidAddressException()
            {
                Console.WriteLine("enter valid Address ");
            }
        }
        public class InvalidNumberException : CustomException
        {
            public InvalidNumberException()
            {
                Console.WriteLine("The entered number is not in the correct format !\n");
            }
        }
        public class InvalidZip : CustomException
        {
            public InvalidZip()
            {
                Console.WriteLine("enter correct zip code");
            }
        }
        public class InvalidState : CustomException
        {
            public InvalidState()
            {
                Console.WriteLine("enter correct format");
            }
        }
        public class InvalidCity : CustomException
        {
            public InvalidCity()
            {
                Console.WriteLine("enter correct city name");
            }
        }
        public class InvalidEmail : CustomException
        {
            public InvalidEmail()
            {
                Console.WriteLine("enter correct Email");
            }
        }
    }
}