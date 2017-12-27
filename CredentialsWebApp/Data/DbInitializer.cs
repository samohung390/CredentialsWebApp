using CredentialsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CredentialsWebApp.Data
{
    public class DbInitializer
    {
        public static void Initialize(StartPointContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.CredAdmins.Any())
            {
                return;   // DB has been seeded
            }

            var CredAdmins = new CredAdmin[]
            {
                new CredAdmin { CredAdminName = "Admin1" }

            };

            foreach (CredAdmin a in CredAdmins)
            {
                context.CredAdmins.Add(a);
            }

            context.SaveChanges();

        
            

        }
    }
}
