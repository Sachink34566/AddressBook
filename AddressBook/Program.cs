using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    public class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            AddDetails addDetails = new AddDetails();

            addDetails.AddDetail(list);

            EditDetails editContacts = new EditDetails();
            editContacts.EditingContact(list);
        }
    }
}
