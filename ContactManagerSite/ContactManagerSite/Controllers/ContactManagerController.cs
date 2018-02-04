using ContactManagerSite.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebService.Models;

namespace ContactManagerSite.Controllers
{
    public class CMController : Controller
    {
        public async System.Threading.Tasks.Task<ActionResult> SaveContactAsync()
        {
            var contact = new Contact
            {
                Name = "Tony",
                PhoneNumber = "5550000",
                Note = "CEO"
            };

            var success = await ContactManagerRepositories.SaveContact(contact);

            if (success) { ViewBag.Message = "Contact has been saved."; }
            else { ViewBag.Message = "Contact has not been saved."; }

            return View();
        }
    }
}