using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.SqlServer
{
    /// <summary>
    /// 单例模式： 类 ，能保证在整个进程中只有一个实例
    /// </summary>
    public class Singletion
    {
        private static Singletion _singletion = null;

        private Singletion()
        {
            Console.WriteLine("Singletion 被构造");
        }

        // crl 调用 程序启动时调用 , 只执行一次
        static Singletion()
        {
            _singletion = new Singletion();        
        }

        public static Singletion GetInstance()
        {
            return _singletion;
        }
    }
}
