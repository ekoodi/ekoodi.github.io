using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Model;

namespace WebApi.Services
{
    public class ContactService : IContactService
    {
        private List<Contact> _contacts;

        public ContactService()
        {
            _contacts = new List<Contact>();
            _contacts.Add(new Contact(1, "Sami", "Anttonen"));
            _contacts.Add(new Contact(2, "Jouni", "Könönen"));
        }

        public List<Contact> FindAllContacts()
        {
            return _contacts;
        }

        public Contact FindContactById(int id)
        {
            return _contacts.FirstOrDefault(contact => contact.Id == id);
        }

        public void SaveContact(Contact contact)
        {
            _contacts.Add(new Contact(GetId(), contact.FirstName, contact.LastName));
        }

        private int GetId()
        {
            var lastSaved = _contacts.OrderByDescending(contact => contact.Id).FirstOrDefault();
            if (lastSaved != null)
            {
                return lastSaved.Id + 1;
            }
            return 1;
        }

 
    }
}
