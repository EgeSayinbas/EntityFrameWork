using _6_ManyToMany.Contexts;
using _6_ManyToMany.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace _6_ManyToMany
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyWebSiteContext db = new MyWebSiteContext();

            #region Many tO Many tablolarda Crud islemleri

            //Role role1 = new Role() { RolName="Admin",CreateDate=DateTime.Now };

            //Role role2 = new Role() { RolName = "User", CreateDate = DateTime.Now };
            //Role role3 = new Role() { RolName = "Satis", CreateDate = DateTime.Now };
            //Role role4 = new Role() { RolName = "Finans", CreateDate = DateTime.Now };

            //User user1= new User() { UserName="ali",Password="123",Email="ali@gmail.com",Gsm="123",CreateDate=DateTime.Now};
            //User user2 = new User() { UserName = "veli", Password = "123", Email = "veli@gmail.com", Gsm = "1234", CreateDate = DateTime.Now };
            //User user3 = new User() { UserName = "ayse", Password = "123", Email = "ayse@gmail.com", Gsm = "1235", CreateDate = DateTime.Now };
            //User user4 = new User() { UserName = "fatma", Password = "123", Email = "fatma@gmail.com", Gsm = "1236", CreateDate = DateTime.Now };

            //db.Users.Add(user1);
            //db.Users.Add(user2);
            //db.Users.Add(user3);
            //db.Users.Add(user4);


            //db.Roller.Add(role1);
            //db.Roller.Add(role2);
            //db.Roller.Add(role3);
            //db.Roller.Add(role4);




            // db.SaveChanges();
            #endregion


            #region Mevcut bir Role mevcut bir user ekleme

            // Ali => Admin , Ayse,veli  => users , Fatma =>Satis rollerine sahip olsun

            //var ali = db.Users.FirstOrDefault(x => x.UserName.ToLower() == "ali");
            //var admin = db.Roller.Include(p => p.Users).FirstOrDefault(p => p.RolName.ToLower() == "admin");
            //admin.Users.Add(ali);
            //db.SaveChanges();

            #region Ayse ve Veli yi User rolune atama 
            //var ayse = db.Users.Include(p=>p.Roles).FirstOrDefault(x => x.UserName.ToLower() == "ayse");
            //var veli = db.Users.Include(p => p.Roles).FirstOrDefault(x => x.UserName.ToLower() == "veli");

            //var user = db.Roller.Include(p => p.Users).FirstOrDefault(p => p.RolName.ToLower() == "user");

            //ayse.Roles.Add(user);
            //veli.Roles.Add(user); 
            #endregion


            #region Ayseyi User'dan Finans Bolumune atama
            var ayse = db.Users.Include(p=>p.Roles).FirstOrDefault(x => x.UserName.ToLower() == "ayse");
            var user = db.Roller.Include(p => p.Users).FirstOrDefault(p => p.RolName.ToLower() == "user");
            ayse.Roles.Remove(user);

            var finans = db.Roller.Include(p => p.Users).FirstOrDefault(p => p.RolName.ToLower() == "finans");
            ayse.Roles.Add(finans);


            #endregion
            db.SaveChanges();
            
            #endregion
            Console.WriteLine("Hello, World!");
        }
    }
}
