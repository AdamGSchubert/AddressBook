using System;
using System.Collections.Generic;

namespace addressBook
{
    public class AddressBook
    {
        



        public Dictionary<string, Contact> contact {get; set;} = new Dictionary<string, Contact>();


        public void AddContact(Contact joe){
            // string FullName = $"{joe.FirstName} {joe.LastName}";
            contact.Add(joe.Email,joe);

        }

        public Contact GetByEmail(string email)
        {
             contact.TryGetValue(email, out Contact person);
             return person;

        }
    }
}