using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;
using System;
using System.Linq;
using test.Models;

[assembly: OwinStartupAttribute(typeof(test.Startup))]
namespace test
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            createRolesandUsers();
        }



        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();
            const string defaultRole = "Admin";
            const string defaultUser = "Customer";

            // This check for the role before attempting to add it.
            if (!context.Roles.Any(r => r.Name == defaultRole))
            {
                context.Roles.Add(new IdentityRole(defaultRole));
                context.SaveChanges();
            }

            // This check for the user before adding them.
            if (!context.Users.Any(u => u.UserName == defaultUser))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);

                //create admin account
                var user = new ApplicationUser ();
                user.UserName = "admin@gmail.com";
                user.CustomerName = "Producer";
                user.Email = "admin@gmail.com";
                user.PhoneNumber = "0921243952";
                user.Address = "agri.tw";

                manager.Create(user, "1qaz@WSX");

                manager.AddToRole(user.Id, defaultRole);
            }
            else
            {
                // Just for good measure, this adds the user to the role if they already
                // existed and just weren't in the role.
                var user = context.Users.Single(u => u.UserName.Equals(defaultUser, StringComparison.CurrentCultureIgnoreCase));
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                manager.AddToRole(user.Id, defaultRole);
            }
        }
    }
}
