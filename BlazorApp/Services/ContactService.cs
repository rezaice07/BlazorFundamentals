using BlazorApp.Data;

namespace BlazorApp.Services
{
    public class ContactService
    {
        public List<Contact> ContactList = new List<Contact>();
        public void AddContact(Contact contact)
        {
            ContactList.Add(contact);
        }
    }
}
