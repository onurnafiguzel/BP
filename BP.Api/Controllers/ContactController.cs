using BP.Api.Models;
using BP.Api.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BP.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration configuration;
        private readonly IContactService contactService;
        public ContactController(IContactService ContactService, IConfiguration Configuration)
        {
            contactService = ContactService;
            configuration = Configuration;
        }

        [HttpGet("{id}")]
        public ContactDVO Get(int id)
        {
            return contactService.GetContactById(id);
        }
    }
}
