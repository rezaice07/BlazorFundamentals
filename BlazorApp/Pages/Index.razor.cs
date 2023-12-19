using BlazorApp.Data;
using BlazorApp.Services;
using BlazorApp.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;

namespace BlazorApp.Pages
{
    public partial class Index
    {
        [Inject]
        IContactService contactService { get; set; }

        [Inject]
        IJSRuntime jsRuntime { get; set; }

        private DeleteConfirmation deleteConfirmation;

        private List<Contact> contacts;
        private bool displayEmailAddress = true;

        //private async Task DeleteContact(Contact contact)
        //{
        //    var res = await jsRuntime.InvokeAsync<bool>("confirm", "Do you want to proceed?");
        //    if (res)
        //    {
        //        contacts.Remove(contact);
        //    }
        //}

        private async Task RequestPermission(Contact contact)
        {
            deleteConfirmation.BodyContent = $"Do you need to delete {contact.FirstName} {contact.LastName} from the list?";
            deleteConfirmation.ContactToDelete = contact;
            deleteConfirmation.Show();
        }

        public async Task OnDeleteConfirmed(Contact contact)
        {
            contacts.Remove(contact);
            deleteConfirmation.Hide();
        }

        protected async override Task OnInitializedAsync()
        {
            //base.OnInitializedAsync();
            await Task.Delay(3000);

            //contacts = contactService.GetContacts();
            contacts = new List<Contact>
            {
                new Contact{FirstName="Rejwanul", LastName="Reja",Email="rezaice07@gmail.com",Phone="8801718055626",Address="Dhaka, Bangladesh" },
                new Contact{FirstName="Khadiza", LastName="Jui",Email="rezaice07@gmail.com" ,Phone="8801718055000",Address="Rangpur, Bangladesh" },
                new Contact{FirstName="Junainah Yousra", LastName="Roha",Email="roha@gmail.com",Phone="8801718055776",Address="Rangpur, Bangladesh"  }
            };
        }

        [JSInvokable]
        public static Task<string> GetValueFromMethod()
        {
            return Task.FromResult<string>("Hello World!");
        }
    }
}
