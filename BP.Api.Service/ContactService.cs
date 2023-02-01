using BP.Api.Data.Models;
using BP.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BP.Api.Service
{
    public class ContactService : IContactService
    {
        public ContactDVO GetContactById(int id)
        {
            // Veritabanından kayıdın getirilmesi
            return null;
        }

        private Contact GetDummyContact()
        {
            return new Contact
            {
                Id = 1,
                FirstName = "Onur",
                LastName = "Güzel"
            };
        }
    }
}
