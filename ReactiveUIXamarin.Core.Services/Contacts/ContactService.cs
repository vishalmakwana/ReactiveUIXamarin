using ReactiveUIXamarin.Core.IServices.Contacts;
using ReactiveUIXamarin.Infrastructure.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIXamarin.Core.Services.Contacts
{
    public class ContactService : IContactService
    {
        private List<ContactDTO> _samples = new List<ContactDTO>()
        {
            new ContactDTO(){Email="VishalMakwana@live.in",FullName="Vishal Makwana",Phone="9898380968"},
            new ContactDTO(){Email="nilesh@live.in",FullName="Nilesh Makwana",Phone="9898380968"},
            new ContactDTO(){Email="Yagnesh@live.in",FullName="Yagnesh Makwana",Phone="123123123213"},
            new ContactDTO(){Email="Krunal@live.in",FullName="Krunal Makwana",Phone="23234234234234213"},
            new ContactDTO(){Email="Yagnisk@live.in",FullName="Yagnisk Makwana",Phone="6565656456"},
            new ContactDTO(){Email="Mashi@live.in",FullName="Mashi Makwana",Phone="4674567567546"},
        };

        public IEnumerable<ContactDTO> GetContacts()
        {
            return _samples;
        }
    }
}
