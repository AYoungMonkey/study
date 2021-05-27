using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp.Study.Interface;

namespace ConsoleApp.Study.MySql
{
    public class MySqlHelper : IDBHelper
    {

        public MySqlHelper()
        {
            Console.WriteLine("{0}被构造", this.GetType().Name);
        }
        public void Query() 
        {
            Console.WriteLine("{0} Query", this.GetType().Name);
        }
    }
}
