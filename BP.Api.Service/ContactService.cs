using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BP.Api.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper mapper;

        public ContactService(IMapper mapper)
        {
            this.mapper = mapper;
        }
        public ContactDVO GetContactById(int id)
        {
            // Veritabanından kayıdın getirilmesi
            Contact dbContact = GetDummyContact();
            ContactDVO resultContact = mapper.Map<ContactDVO>(dbContact);
            return resultContact;
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
