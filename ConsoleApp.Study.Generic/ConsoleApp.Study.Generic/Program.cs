using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            string sValue = "123";
            int iValue = 89;
            DateTime dtVlue = DateTime.Now;

            Common.ShowInt(iValue);
            Common.ShowString(sValue);
            Common.ShowDatetime(dtVlue);
            Console.WriteLine("**************Obejct****************");

            Common.ShowObject(iValue);
            Common.ShowObject(sValue);
            Common.ShowObject(dtVlue);
            Console.WriteLine("**************Generic****************");

            Common.Show<int>(iValue);
            Common.Show<string>(sValue);
            Common.Show<DateTime>(dtVlue);

            GenericCacheTest.Test();
            Console.ReadLine();
        }
    }
}
