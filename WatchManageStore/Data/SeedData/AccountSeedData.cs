using Microsoft.AspNetCore.Identity;
using WatchManageStore.Models;

namespace WatchManageStore.Data.SeedData
{
    public static class Role
    {
        public static readonly string Administrator = "Administrator";
        public static readonly string Account = "Account";
    }

    public static class AccountSeedData
    {
        public static void Seed(UserManager<Account> userManager,
            RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<Account> userManager)
        {
            //var users = userManager.GetUsersInRoleAsync("Account").Result;

            if (userManager.FindByEmailAsync("admin@localhost.com").Result == null)
            {
                var user = new Account
                {
                    Id = "408aa945-3d84-4421-8342-7269ec64d949",
                    UserName = "admin@localhost.com",
                    FirstName = "Admin",
                    LastName = "Admin",
                    Email = "admin@localhost.com"
                };
                var result = userManager.CreateAsync(user, "P@ssword1").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, Role.Administrator).Wait();
                }
            }
            if (userManager.FindByEmailAsync("syha@gmail.com").Result == null)
            {
                var user = new Account
                {
                    Id = "408aa945-3d84-4421-8342-7269ec64d950",
                    UserName = "syha@gmail.com",
                    FirstName = "Sy",
                    LastName = "Ha",
                    Email = "syha@gmail.com"
                };
                var result = userManager.CreateAsync(user, "SyHa123!").Result;
                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, Role.Account).Wait();
                }
            }
        }

        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(Role.Administrator).Result)
            {
                var role = new IdentityRole
                {
                    Name = Role.Administrator
                };
                var result = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(Role.Account).Result)
            {
                var role = new IdentityRole
                {
                    Name = Role.Account
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }

}
