using ConsoleApp.Study.Interface;
using ConsoleApp.Study.Oracle;
using ConsoleApp.Study.SqlServer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp.Study.Reflection
{
    public class Monitor
    {
        public static void show()
        {
            Console.WriteLine("****************Monitor*******************");
            long commonTime = 0;
            long reflectionTime = 0;

            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                for (int i = 0; i < 1000000; i++)
                {
                    IDBHelper dBHelper = new OracleHelper();
                    dBHelper.Query();

                }
                watch.Stop();
                commonTime = watch.ElapsedMilliseconds;
            }

            {
                Stopwatch watch = new Stopwatch();
                watch.Start();
                // 1.动态加载 DLL EXE文件
                Assembly assembly = Assembly.Load("ConsoleApp.Study.Oracle"); // 默认在当前目录下查找
                                                                              // 2.获取类型
                Type type = assembly.GetType("ConsoleApp.Study.Oracle.OracleHelper");
                for (int i = 0; i < 1000000; i++)
                {
                    
                    // 3.创建对象
                    object DBHelper = Activator.CreateInstance(type);
                    // 4.类型转换
                    IDBHelper dBHelper2 = DBHelper as IDBHelper; // 转换类型 as : 不成功是返回NULL （Type）: 返回错误
                    dBHelper2.Query();

                }
                watch.Stop();
                reflectionTime = watch.ElapsedMilliseconds;
            }
            Console.WriteLine("connontime is {0} --- reflectiontime is {1}", commonTime, reflectionTime);
        }
        
    }
}
