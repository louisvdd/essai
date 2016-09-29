using Labo_3;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject1
{
    class DbInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {
            Customer customer = new Customer()
            {
                AccountBalance = 199.5,
                Name = "oli",
                AdressLine1 = "rue du Bouovreuil",
                AdressLine2 = " rue du bouki",
                City = "Charleroi",
                Country = "belgique",
                Email = "olikity@gmail.com",
                id = 3,
                Remark = "etre Carolo"
            };

            context.Customers.Add(customer);
            context.SaveChanges();
        }
    }
}
