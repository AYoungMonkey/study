using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp.Study.Generic
{

    public class GenericCacheTest
    {
        public static void Test()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(GenericCache<int>.GetCache());
                Thread.Sleep(10);
                Console.WriteLine(GenericCache<string>.GetCache());
                Thread.Sleep(10);
                Console.WriteLine(GenericCache<double>.GetCache());
                Thread.Sleep(10);
            }
        }
    }

    /// <summary>
    /// 泛型缓存 ： 会根据传入的类型不同，生成不同的副本
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericCache<T>
    {
        static GenericCache()
        {
            Console.WriteLine("This is GenericCache 静态构函数");
            _TypeTime = string.Format("{0}_{1}", typeof(T).FullName, DateTime.Now.ToString("yyyyMMddHHmmss.fff"));
        }

        private static string _TypeTime = "";

        public static string GetCache()
        {
            return _TypeTime;
        }
    }
}
