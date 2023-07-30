using ProcessRUs.Entities;

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
                Console.WriteLine("--> Seeding Data... ");
                context.Users.AddRange(
                    new User() {Name = "FrontOffice" },
                    new User() {Name = "BackOffice" },
                    new User() {Name = "Admin" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }

        private static void SeedFruits(ProcessRUsContext context)
        {
            if (!context.Fruits.Any())
            {
                Console.WriteLine("--> Seeding Data... ");
                context.Fruits.AddRange(
                    new Fruit() {Name = "Pear" }
                    );
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("--> We already have data");
            }
        }
    }
}
