using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu20_static.Libs
{
    static class AppUtils
    {
        public static int Multiplyby3(this int x, int y)
        {
            return x * 3;
        }

        public static int SomeMethodDb(this Database db)
        {
            // Some operations db...
            return 34;
        }
    }
}
