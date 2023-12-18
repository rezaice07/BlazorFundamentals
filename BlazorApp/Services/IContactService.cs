using BlazorApp.Data;
using BlazorApp.Pages.ContactComponents;

namespace BlazorApp.Services
{
    public interface IContactService
    {
        void AddContact(Contact contact);
        List<Contact> GetContacts();
    }
}
