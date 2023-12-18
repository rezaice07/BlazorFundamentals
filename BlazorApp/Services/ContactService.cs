using BlazorApp.Data;
using BlazorApp.Pages.ContactComponents;

namespace BlazorApp.Services
{
    public class ContactService: IContactService
    {
        public List<Contact> contactList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            contactList.Add(contact);
        }

        public List<Contact> GetContacts()
        {
            return contactList;
        }
    }
}
