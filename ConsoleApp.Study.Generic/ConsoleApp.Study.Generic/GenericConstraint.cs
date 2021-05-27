using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Generic
{
    /// <summary>
    /// 泛型约束
    /// </summary>
    public class GenericConstraint
    {
        public static void ShowObject(object oPara)
        {
            Console.WriteLine("This is {0}, Type is {1}", oPara, oPara.GetType().Name);
        }
    }
}
