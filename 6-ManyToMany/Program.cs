using _6_ManyToMany.Contexts;
using _6_ManyToMany.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;

namespace _6_ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyWebSiteContext db = new MyWebSiteContext();

            #region Many to Many tablolarda Crud İslemleri

            //Role role1 = new Role() { RolName = "Admin", CreateDate = DateTime.Now };
            //Role role2 = new Role() { RolName = "User", CreateDate = DateTime.Now };
            //Role role3 = new Role() { RolName = "Satis", CreateDate = DateTime.Now };
            //Role role4 = new Role() { RolName = "Finans", CreateDate = DateTime.Now };

            //User user1 = new User() { UserName = "Ali", Password = "123", Email = "ali@gmail.com", Gsm = "123", CreateDate = DateTime.Now };
            //User user2 = new User() { UserName = "Veli", Password = "123", Email = "veli@gmail.com", Gsm = "1234", CreateDate = DateTime.Now };
            //User user3 = new User() { UserName = "Ayse", Password = "123", Email = "ayse@gmail.com", Gsm = "12345", CreateDate = DateTime.Now };
            //User user4 = new User() { UserName = "Fatma", Password = "123", Email = "fatma@gmail.com", Gsm = "123456", CreateDate = DateTime.Now };

            //db.Users.Add(user1);
            //db.Users.Add(user2);
            //db.Users.Add(user3);
            //db.Users.Add(user4);

            //db.Roller.Add(role1);
            //db.Roller.Add(role2);
            //db.Roller.Add(role3);
            //db.Roller.Add(role4);


            //db.SaveChanges();
            #endregion

            #region Mevcut Bir Role Mevcut Bir User Ekleme

            //ali => admin , ayse, veli => user , fatma => satis
            //var ali = db.Users.FirstOrDefault(x => x.UserName.ToLower() == "ali");
            //var admin = db.Roller.Include(p => p.Users).FirstOrDefault(p => p.RolName.ToLower() == "admin");
            //admin.Users.Add(ali);
            //db.SaveChanges();

            var ayse = db.Users.Include(p => p.Roles).FirstOrDefault(x => x.UserName.ToLower() == "ayse");
            var veli = db.Users.Include(p => p.Roles).FirstOrDefault(x => x.UserName.ToLower() == "veli");
            var user = db.Roller.Include(p => p.Users).FirstOrDefault(p => p.RolName.ToLower() == "users");
            ayse.Roles.Add(user);
            veli.Roles.Add(user);

            db.SaveChanges();
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
