using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using ContactManagerSite.Repositories;
using WebService.Models;

namespace ContactManagerSite
{
    public class ContactManagerProcessor
    {
        public static async Task<bool> Process(Contact contact)
        {
            // Process, Calculate, Format, etc.

            return await ContactManagerRepositories.SaveContact(contact);
        }
    }
}