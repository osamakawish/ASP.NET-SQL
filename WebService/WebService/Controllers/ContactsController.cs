using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;
using WebService.Processors;

namespace WebService.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpPost]
        [Route("SaveContact")]
        
        public bool SaveContact(Contact contact)
        {
            if (contact != null)
            {
                return ContactProcessor.ProcessContact(contact);
            }

            return false;
        }
    }
}
