using _10_Global_Query_Filtering.Contexts;
using _10_Global_Query_Filtering.Entites.Concrete;

namespace _10_Global_Query_Filtering
{
    #region Global Query Filters Nedir?
    //Bir entity'e özel uygulama seviyesinde genel/ön kabullü şartlar oluşturmamızı ve
    //böylece verileri global bir şekilde filtrelememizi sağlayan bir özelliktir.
    //Böylece belirtilen entity üzerinden yapılan tüm sorgulamalarda ekstradan bir şart
    //ifadesine gerek kalmaksızın filtreleri otomatik uygulayarak hızlıca sorgulama
    //yapmamızı sağlamaktadır.

    //Genellikle uygulama bazında aktif(IsActive) gibi verilerle çalışıldığı durumlarda,
    //MultiTenancy uygulamalarda TenantId tanımlarken vs. kullanılabilri.
    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            SqlDbContext db = new SqlDbContext();
            #region Kayit Ekleme

            //Person person1 = new Person() { Name="Ali" ,SureName="Yilmaz"};
            //Person person2 = new Person() { Name = "Veli", SureName = "Yilmaz" };
            //Person person3 = new Person() { Name = "Ayse", SureName = "Yilmaz" };
            //Person person4 = new Person() { Name = "Fatma", SureName = "Yilmaz" };

            //db.Persons.Add(person1);
            //db.Persons.Add(person2);
            //db.Persons.Add(person3);
            //db.Persons.Add(person4);
            //db.SaveChanges();

            #endregion

            #region Sorgulama
            //var result = db.Persons.Where(p => p.IsDelete == false).ToList();
            //var result2 = db.Persons.ToList();
            #endregion

            #region Kayit Silme => olmasi gereken Isdelete alanini update etmektir
            //var fatma = db.Persons.FirstOrDefault(p => p.Id == 4);
            //fatma.IsDelete = true;
            //db.SaveChanges();
            //var result = db.Persons.ToList();
            #endregion

            #region Peki Persons tablosunda Remove islemi uygulanirsa ne olur ?
            //var veli = db.Persons.FirstOrDefault(p => p.Id == 2);
            ////fatma.IsDelete = true;
            //db.Persons.Remove(veli);
            //db.SaveChanges();
            //var result = db.Persons.ToList();
            #endregion
            #region Yeni Person eklendiginde Bazi menulerin eklenmeis senaryosu
            var person = new Person() { Name = "Hasan", SureName = "Kacar" };
            db.Persons.Add(person); 
            db.SaveChanges();
            #endregion


            Console.WriteLine("Hello, World!");
        }
    }
}
