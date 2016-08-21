using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu20_static.Libs
{
    class Database
    {
        public static string Login;
        public static string Password;
        public static int Port;
        public static string DbName;

        public int dbhandle = 0;

        public void Connect()
        {
            Console.WriteLine("Łączę się do bazy {0} jako {1}@localhost:{2} z hasłem {3}...", DbName, Login, Port, Password);
            dbhandle = 123123;
        }

        public void Query(string dbquery)
        {
            Console.WriteLine("{0}: Wykonuję zapytanie {1}", dbhandle, dbquery);
        }
    }
}
