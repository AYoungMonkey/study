using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.SqlServer
{
    public class GencericMethod
    {
        public void show<T, W, X>(T t, W w, X x)
        {
            Console.WriteLine("t.type = {0} , w.type = {1}, x.type = {2}", t.GetType().Name, w.GetType().Name, x.GetType().Name);
        }
    }

    public class GencericClass<T, W, X>
    {
        public void show(T t, W w, X x)
        {
            Console.WriteLine("t.type = {0} , w.type = {1}, x.type = {2}", t.GetType().Name, w.GetType().Name, x.GetType().Name);
        }
    }

    public class GenericDouble<T>
    {
        public void show<W, X>(T t, W w, X x)
        {
            Console.WriteLine("t.type = {0} , w.type = {1}, x.type = {2}", t.GetType().Name, w.GetType().Name, x.GetType().Name);
        }
    }

    
}
