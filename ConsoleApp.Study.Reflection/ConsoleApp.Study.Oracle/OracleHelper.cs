using ConsoleApp.Study.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Oracle
{
    public class OracleHelper : IDBHelper
    {
        public OracleHelper()
        {
            // Console.WriteLine("{0}被构造", this.GetType().Name);
        }

        public void Query()
        {
            // Console.WriteLine("{0} Query", this.GetType().Name);
        }
    }
}
