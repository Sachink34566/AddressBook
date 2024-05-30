using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace AddressBook
{
    public class Validation
    {
        private string Patname { get; set; } = "[A-Z][a-z]{2,9}";
        private string Address { get; set; } = @"^[A-Za-z0-9\s.,#-]+$";
        private string Number { get; set; } = @"^[0-9]{10}$";
        private string Zip { get; set; } = "[0-6{6}";

        private string Email { get; set; } = @"^\w{3,}([.+-]\w{1,})?@\w{1,}.[a-z]{1,}(.[a-z]{1,})?$";



        public bool IsName(string name)
        {
            if (Regex.IsMatch(name, Patname)) return true;
            return false;
        }
        public bool IsAddress(string address)
        {
            if (Regex.IsMatch(address, Address)) return true;
            return false;
        }
        public bool IsNumber(string number)
        {
            if (Regex.IsMatch(number, Number)) return true;
            return false;
        }
        public bool IsZip(string zip)
        {
            if (Regex.IsMatch(zip, Zip)) return true;
            return false;
        }
        public bool IsEmail(string email)
        {
            if (Regex.IsMatch(email, Email)) return true;
            return false;
        }
        public bool IsState(string state)
        {
            if (Regex.IsMatch(Patname, state)) return true;
            return false;
        }
        public bool IsCity(string city)
        {
            if (Regex.IsMatch(Patname, city)) return true;
            return false;
        }



    }
}