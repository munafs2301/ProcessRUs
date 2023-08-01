using ProcessRUs.Entities;
using ProcessRUs.Helpers;

namespace ProcessRUs.Data
{
    public static class SeedDb
    {
        public static void PrepDb(this IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                SeedUsers(serviceScope.ServiceProvider.GetService<ProcessRUsContext>());
                SeedFruits(serviceScope.ServiceProvider.GetService<ProcessRUsContext>());
            }
        }
        private static void SeedUsers(ProcessRUsContext context)
        {
            if (!context.Users.Any())
            {
                Console.WriteLine("--> Seeding Users... ");
                context.Users.AddRange(
                    new User() {Username = "FrontOffice" , Email= "frontoffice@processrus.com", Password = "FrontOffice@01", Firstname = "FrontOffice", Lastname = "ProcessRUs", Role = "Client"},
                    new User() {Username = "BackOffice", Email= "backoffice@processrus.com", Password = "BackOffice@01", Firstname = "BackOffice", Lastname = "ProcessRUs", Role = "BackOffice" },
                    new User() {Username = "Admin", Email= "admin@processrus.com", Password = "Admin@01", Firstname = "Admin", Lastname = "ProcessRUs", Role = "Admin" }
                    );
                context.SaveChanges();
            }
        }

        private static void SeedFruits(ProcessRUsContext context)
        {
            if (!context.Fruits.Any())
            {
                Console.WriteLine("--> Seeding Fruits... ");
                context.Fruits.AddRange(
                    new Fruit() {Name = "Strawberry", Type = FruitType.Berry },
                    new Fruit() {Name = "Blueberry", Type = FruitType.Berry },
                    new Fruit() {Name = "Pineapple", Type = FruitType.Tropical },
                    new Fruit() {Name = "Mango", Type = FruitType.Tropical },
                    new Fruit() {Name = "Apple", Type = FruitType.Pome },
                    new Fruit() {Name = "Pear", Type = FruitType.Pome }
                    );
                context.SaveChanges();
            }
        }
    }
}
