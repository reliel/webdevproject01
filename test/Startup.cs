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
            createRolesandUsers();
            ConfigureAuth(app);
            
        }

        private void createRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup iam creating first Admin Role and creating a default Admin User     
            if (!context.Users.Any(u =>u.UserName == "admin@gmail.com") )
            {
                //Here we create a Admin super user who will maintain the website                   

                var user = new ApplicationUser();
                user.UserName = "admin@gmail.com";
                user.Email = "admin@gmail.com";
                user.CustomerName = "Admin";
                user.PhoneNumber = "0921243952";
                user.Address = "webcity107a";
                UserManager.Create(user, "1qaz@WSX");
                UserManager.AddToRole(user.Id, "1");
 
                
            }

            

            
        }

    }
}
