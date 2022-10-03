using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;

namespace MvcBlogSitesi.Identity
{
    public class IdentityInitializer:CreateDatabaseIfNotExists<IdentityDataContext>
    {
        protected override void Seed(IdentityDataContext context)
        {
            if (!context.Roles.Any(i=>i.Name=="admin"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "admin", Description = "admin rolü" };
                manager.Create(role);
            }
            if (!context.Roles.Any(i => i.Name == "user"))
            {
                var store = new RoleStore<ApplicationRole>(context);
                var manager = new RoleManager<ApplicationRole>(store);
                var role = new ApplicationRole() { Name = "user", Description = "user rolü" };
                manager.Create(role);
            }
            if (!context.Users.Any(i=>i.Name == "melisalpkaya"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                { Name = "melis", Surname = "alpkaya" ,UserName="melisalpkaya",Email="melisalpkaya@gmail.com"};
                manager.Create(user,"123456");
                manager.AddToRole(user.Id, "admin");
              
            }
            if (!context.Users.Any(i => i.Name == "denizalpkaya"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser()
                { Name = "deniz", Surname = "alpkaya", UserName = "denizalpkaya", Email = "denizalpkaya@gmail.com" };
                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "user");
            }
            base.Seed(context); 

        }
    }
}