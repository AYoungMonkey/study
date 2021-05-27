using ConsoleApp.Study.Interface;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp.Study.Reflection
{
    public class SimlpFactory
    {
        public static string str = ConfigurationManager.AppSettings["IDBHelperConfig"];
        public static string dllname = str.Split(',')[0];
        public static string typename = str.Split(',')[1];
        public static IDBHelper CreateInstentce()
        {
            
            // 1.动态加载 DLL EXE文件
            Assembly assembly = Assembly.Load(dllname); // 默认在当前目录下查找
            // 2.获取类型
            Type type = assembly.GetType(typename);
            // 3.创建对象
            object DBHelper = Activator.CreateInstance(type);
            // 4.类型转换
            IDBHelper dBHelper2 = DBHelper as IDBHelper; // 转换类型 as : 不成功是返回NULL （Type）: 返回错误
            return dBHelper2;
        }
    }
}
