using AssignmentMVC.App_Start;
using AssignmentMVC.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace AssignmentMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
            container.RegisterType<IUserStore<Account>, UserStore<Account>>();
            container.RegisterType<UserManager<Account>>();
            container.RegisterType<DbContext, MyDbContext>();
            container.RegisterType<MyUserManager>();
        }
    }
}