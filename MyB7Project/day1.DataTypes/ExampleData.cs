using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyB7Project.day1.DataTypes
{
    class ExampleData
    {        
        static void Main(string[] args)
        {
            const int t = 5;

            short s = 5;
            int x = 5;
            x = 7;
            long xx = 5;

            float y = 5.5f;
            double z = 5.5;

            string text = "Hello world";
            char c = '\u0058';

            decimal d = 5.5M;
            object o = 'D';
            o = true;

            var p = 5;

            string ss = null;
            string sss = string.Empty;

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime);

            
        }
    }

}
