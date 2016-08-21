using edu20_static.Libs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu20_static
{
    class Program
    {
        static void Main(string[] args)
        {
            // Elementy statyczne - metody i właściwości
            Database.Login = "admnet";
            Database.Password = "Bosman,1972";
            Database.Port = 3306;
            Database.DbName = "pierodb";

            var db1 = new Database();
            db1.Connect();
            db1.Query("SELECT * FROM users");

            var db2 = new Database();
            db2.Connect();
            db2.Query("SELECT * FROM posts");

            // Metody Extension
            int i = 10;
            Console.WriteLine(i.Multiplyby3(2));
            Console.WriteLine(AppUtils.Multiplyby3(i, 2));

            Console.WriteLine(db1.SomeMethodDb());

            Console.ReadLine();
        }
    }
}
