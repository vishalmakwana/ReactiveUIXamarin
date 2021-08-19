using ReactiveUIXamarin.Infrastructure.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ReactiveUIXamarin.Core.IServices.Contacts
{
    public interface IContactService
    {
        public IEnumerable<ContactDTO> GetContacts();
    }
}
