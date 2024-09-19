namespace _1_DbFirst
{
    internal class Program
    {

        #region Gerekli ortamin hazirlanmasi

        /*
         * 1- EntityFramework tool un u kurmak
         * bunu komut satiri uzerinden yapicaz (terminal) dotnet tool install --global dotnet-ef    ef tool paketini yukler
         * 
         * ayrica projemize EntityFrameWorkCore paketini ve hangi databese ile calisacaksak mesela EntityFrameWorkCore.SqlServer ilgili paketini
         * ve EntityFrameWork.Design paketini kurmak gereklidir
         * bu paketleri nuget uzerinden indirebiliriz
         * 
         * dotnet ef dbcontext scaffold "server=.;Database=Northwind;Trusted_Connection=true;TrustServerCertificate=true" Microsoft.EntityFrameWorkCore.SqlServer -o Entities
 
         */
        #endregion
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
