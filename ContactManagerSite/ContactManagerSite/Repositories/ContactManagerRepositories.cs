using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using WebService.Models;

namespace ContactManagerSite.Repositories
{
    public class ContactManagerRepositories
    {
        public static async Task<bool> SaveContact(Contact contact)
        {
            var client = new HttpClient();
            var jsonContent = JsonConvert.SerializeObject(contact);
            var httpContent = new StringContent(jsonContent, Encoding.UTF8, "application/json");
            var respone = await client.PostAsync("http://localhost:53677/SaveContact", httpContent);
            var responseString = await respone.Content.ReadAsStringAsync();
            return responseString != "false";
        }
    }
}