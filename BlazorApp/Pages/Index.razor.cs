using BlazorApp.Data;
using BlazorApp.Pages.ContactComponents;
using BlazorApp.Services;
using Microsoft.AspNetCore.Components;

namespace BlazorApp.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService contactService { get; set; }

        private List<Contact> contacts;
        private ContactListComponent contactListComponent;
        private bool isContactDisplayed = true;
        private bool displayEmailAddress = true;
        private bool displayContact = true;

        

        private void DeleteContact(Contact contact)
        {
            contacts.Remove(contact);
        }

        protected async override Task OnInitializedAsync()
        {
            //base.OnInitializedAsync();
            await Task.Delay(3000);

            contacts = contactService.GetContacts();
            //contacts = new List<ContactModel>
            //{
            //    new ContactModel{FirstName="Rejwanul", LastName="Reja",Email="rezaice07@gmail.com",Phone="8801718055626",Address="Dhaka, Bangladesh" },
            //    new ContactModel{FirstName="Khadiza", LastName="Jui",Email="rezaice07@gmail.com" ,Phone="8801718055000",Address="Rangpur, Bangladesh" },
            //    new ContactModel{FirstName="Junainah Yousra", LastName="Roha",Email="roha@gmail.com",Phone="8801718055776",Address="Rangpur, Bangladesh"  }
            //};
        }

        private void HideContacts()
        {
            isContactDisplayed = !isContactDisplayed;

            
            //if (isContactDisplayed)
            //{
            //    contactListComponent.ShowContact();
            //}
            //else
            //{
            //    contactListComponent.HideContact(); 
            //}
        }
    }
}
