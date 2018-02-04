using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebService.Models;

namespace WebService.Repositories
{
    public class ContactRepository
    {
        public static bool AddContactToDB(Contact contact)
        {
            // Change server in connection string.
            var connectionString = "Server=ACER-LAPTOP\\SQLEXPRESS;Integrated Security=true;Initial Catalog=ContactManager";
            var query = "INSERT INTO ContactList (Name,[Phone Number],Note) VALUES ('@Name', '@PhoneNum', '@Note')";

            query = query.Replace("@Name", contact.Name)
                .Replace("@PhoneNum", contact.PhoneNumber)
                .Replace("@Note", contact.Note);

            SqlConnection connection = new SqlConnection(connectionString);

            connection.Open();
            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            command.Dispose();
            connection.Close();
            return true;

            //try
            //{
                
            //}
            //catch (Exception)
            //{
            //    return false;
            //}
        }
    }
}