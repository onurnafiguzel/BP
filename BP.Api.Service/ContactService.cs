using AutoMapper;
using BP.Api.Data.Models;
using BP.Api.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace BP.Api.Service
{
    public class ContactService : IContactService
    {
        private readonly IMapper mapper;
        private readonly IHttpClientFactory httpClientFactory;

        public ContactService(IMapper mapper, IHttpClientFactory httpClientFactory)
        {
            this.mapper = mapper;
            this.httpClientFactory = httpClientFactory;
        }
        public ContactDVO GetContactById(int id)
        {
            // Veritabanından kayıdın getirilmesi
            Contact dbContact = GetDummyContact();

            var client = httpClientFactory.CreateClient("garantiapi");

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
