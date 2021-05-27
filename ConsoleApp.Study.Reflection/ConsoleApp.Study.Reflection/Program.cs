using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using ConsoleApp.Study.SqlServer;
using ConsoleApp.Study.Interface;
using System.Configuration;
using ConsoleApp.Study.Model;

namespace ConsoleApp.Study.Reflection
{
    /// <summary>
    /// IL:中间语言，标准的面向对象语言，不易阅读
    /// metadata:元数据，数据清单
    /// 反射：Reflection, System.Reflection命名空间，是微软提供的一个帮助类库
    /// </summary>
    class Program
    {
        
        static void Main(string[] args)
        {

            #region common
            {
                //IDBHelper dBHelper = new SqlServerHelper();
                //dBHelper.Query();
            }
            #endregion

            #region Reflection
            {
                // 1.动态加载 DLL EXE文件
                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer"); // 默认在当前目录下查找
                //Assembly assembly1 = Assembly.LoadFile(@"D:\C#\写着玩\ConsoleApp.Study.Reflection\ConsoleApp.Study.SqlServer\bin\Debug\ConsoleApp.Study.SqlServer.dll"); //根据DLL路径去查找 全路径 + dll名称 + 后缀
                //Assembly assembly2 = Assembly.LoadFrom("ConsoleApp.Study.SqlServer.dll"); // 全名称去查找，也可以写全路径
                //Assembly assembly3 = Assembly.LoadFrom(@"D:\C#\写着玩\ConsoleApp.Study.Reflection\ConsoleApp.Study.SqlServer\bin\Debug\ConsoleApp.Study.SqlServer.dll");

                //foreach (var item in assembly.GetTypes())
                //{
                //    foreach (var item1 in item.GetMethods())
                //    {
                //        Console.WriteLine(item1);
                //    }
                //}
            }

            {
                //// 1.动态加载 DLL EXE文件
                //Assembly assembly = Assembly.Load("ConsoleApp.Study.MySql"); // 默认在当前目录下查找
                //// 2.获取类型
                //Type type = assembly.GetType("ConsoleApp.Study.MySql.MySqlHelper");
                //// 3.创建对象
                //object DBHelper = Activator.CreateInstance(type);


                ////DBHelper.Query(); // 编译器不认可 C#是强类型语言，编译时确认类型

                ////dynamic DBHelper1 = Activator.CreateInstance(type);
                ////DBHelper1.Query(); //dynamic 是一个动态类型，可以避开编译器的检查，程序运行时检查 存在安全问题，对象里没有的方法也不会报错

                //// 4.类型转换
                //IDBHelper dBHelper2 = DBHelper as IDBHelper; // 转换类型 as : 不成功是返回NULL （Type）: 返回错误
                //// 5.调用方法
                //dBHelper2.Query();
            }

            {
                // 封装 Factory + Config 实现程序的可配置，不需要在编译
                //IDBHelper dBHelper = SimlpFactory.CreateInstentce();
                //dBHelper.Query();

                // 程序的可扩展
                // 1.添加一个Oracle类库
                // 2.把生成的DLL Copy到当前程序目录下
                // 3.修改配置文件
            }

            {
                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer");
                //Type type = assembly.GetType("ConsoleApp.Study.SqlServer.ReflectionTest");
                //object DBHelper = Activator.CreateInstance(type); // 无参数构造函数
                //object DBHelper1 = Activator.CreateInstance(type,new object[] { "刘亚西" }); // 有参数构造函数 string
                //object DBHelper2 = Activator.CreateInstance(type, new object[] { 28 }); // 有参数构造函数 int
            }

            // 反射调用方法
            {
                //// 先获取方法，然后方法Invoke
                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer");
                //Type type = assembly.GetType("ConsoleApp.Study.SqlServer.ReflectionTest");
                //object DBHelper = Activator.CreateInstance(type); // 无参数构造函数

                //MethodInfo show1 = type.GetMethod("show1");
                //show1.Invoke(DBHelper, new object[] { });

                //// 反射调用方法 传入参数一定要和参数类型一致
                //MethodInfo show2 = type.GetMethod("show2");
                //show2.Invoke(DBHelper, new object[] { 123 });
                //// 重载方法 获取方法定义好参数类型
                //MethodInfo show3 = type.GetMethod("show3", new Type[] { typeof(string), typeof(int) });
                //show3.Invoke(DBHelper, new object[] { "上巨虚", 123 });

                //// 私有方法

                //// 反射调用静态方法 对象实例可以传入也可以传入Null
                //MethodInfo show5 = type.GetMethod("show5", new Type[] { typeof(string) });
                //show5.Invoke(DBHelper, new object[] { "截面" });
                //show5.Invoke(null, new object[] { "上巨虚" });

            }

            // 反射破坏单例  其实就是反射调用私有构造函数
            {
                //Singletion singletion1 = Singletion.GetInstance();
                //Singletion singletion2 = Singletion.GetInstance();
                //Singletion singletion3 = Singletion.GetInstance();
                //Console.WriteLine(singletion1.Equals(singletion3));

                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer");
                //Type type = assembly.GetType("ConsoleApp.Study.SqlServer.Singletion");
                //object oSingletion1 = Activator.CreateInstance(type, true);
                //object oSingletion2 = Activator.CreateInstance(type, true);
                //object oSingletion3 = Activator.CreateInstance(type, true);
                //object oSingletion4 = Activator.CreateInstance(type, true);
                //Console.WriteLine(oSingletion1.Equals(oSingletion3));
            }

            // 反射调用泛型方法
            {
                // 泛型编译之后生成占位符 `1 `2 `3
                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer");
                //Type type = assembly.GetType("ConsoleApp.Study.SqlServer.GencericMethod");
                //object oTest = Activator.CreateInstance(type);

                //MethodInfo genericMethod = type.GetMethod("show");
                //MethodInfo genericMethod1 = genericMethod.MakeGenericMethod(new Type[] { typeof(int), typeof(string), typeof(DateTime) }); // 指定泛型方法的具体参数
                //genericMethod1.Invoke(oTest, new object[] { 28, "刘亚西", DateTime.Now }); // 传入必须和声明的一样


                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer");
                //Type type = assembly.GetType("ConsoleApp.Study.SqlServer.GencericClass`3"); // 获取一个泛型类型
                //Type type1 = type.MakeGenericType(new Type[] { typeof(int), typeof(string), typeof(DateTime) }); // 指定泛型类型的具体参数

                //object oGenericTest = Activator.CreateInstance(type1);
                //MethodInfo genericMethod = type1.GetMethod("show");
                //genericMethod.Invoke(oGenericTest, new object[] { 18 , "刘亚栋", DateTime.Now });

                //Assembly assembly = Assembly.Load("ConsoleApp.Study.SqlServer");
                //Type type = assembly.GetType("ConsoleApp.Study.SqlServer.GenericDouble`1"); // 获取一个泛型类型
                //Type type1 = type.MakeGenericType(new Type[] { typeof(int) });

                //object oGenericTest = Activator.CreateInstance(type1);
                //MethodInfo methodInfo = type1.GetMethod("show");
                //MethodInfo methodInfo1 = methodInfo.MakeGenericMethod(new Type[] { typeof(string), typeof(DateTime) });
                //methodInfo1.Invoke(oGenericTest, new object[] { 18, "刘亚栋", DateTime.Now });
            }

            {
                // 反射的特点:
                // 优点
                // 1.动态加载DLL EXE 减少对象和对象之间的依赖,只需要类名(字符串),方法名,就可以调用
                // 2.可以突破特定权限, 可以做到普通方法无法做到的(获取私有属性,方法)
                // 缺点
                // 3.编写比较困难, 代码量大, 易出错
                // 4.性能问题, 性能损耗大
                Monitor.show();
                // 经过调试, 性能损耗确实大, 该机调试下普通方式 11ms , 反射方式 70ms

                // 反射的应用
                // 1.创建对象---IOC
                // 2.通过一些字符串可能访问方法 --- MVC : localhost://Home/index?id=1  Home:控制器 index:方法
                // 3.ORM

                {
                    // 反射如何使用属性字段

                    People people = new People();
                    people.Id = 1;
                    people.Name = "AA";
                    people.Description = "AAAAAAAAA";
                    Console.WriteLine($"people.Id = {people.Id}");
                    Console.WriteLine($"people.Name = {people.Name}");
                    Console.WriteLine($"people.Description = {people.Description}");
                    
                    Type type = typeof(People);
                    object opeople = Activator.CreateInstance(type);

                    foreach (PropertyInfo prop in type.GetProperties())
                    {
                        if (prop.Name.Equals("id"))
                        {
                            prop.SetValue(opeople, 123, null);
                        }


                        Console.WriteLine($"opeople.{prop.Name}={prop.GetValue(opeople, null)}");
                    }

                }
            }

            #endregion
            Console.ReadLine();

        }
    }
}
