using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Generic
{
    public class Common
    {
        public static void ShowInt(int iPara)
        {
            Console.WriteLine("This is {0}, Type is {1}", iPara , iPara.GetType().Name);
        }

        public static void ShowString(string sPara)
        {
            Console.WriteLine("This is {0}, Type is {1}", sPara, sPara.GetType().Name);
        }

        public static void ShowDatetime(DateTime dPara)
        {
            Console.WriteLine("This is {0}, Type is {1}", dPara, dPara.GetType().Name);
        }

        /// <summary>
        /// C#：任何父类出现的地方，都可以用子类代替
        /// Object 类型是一切类型的父类
        /// 
        /// Object 出现可以让任何类型都传入
        /// 
        /// 但是：有两个问题
        ///         性能问题，会出现装箱和拆箱
        ///         类型安全问题
        /// </summary>
        /// <param name="oPara"></param>
        public static void ShowObject(object oPara)
        {
            Console.WriteLine("This is {0}, Type is {1}", oPara, oPara.GetType().Name);
        }

        /// <summary>
        /// 泛型方法： 需要在方法后面加一个<> 需要定义T
        /// T ： 类型参数 ，只是一个点位符，类型不确定，在调用时确定类型
        /// 泛型： 泛型方法，泛型类，泛型接口，泛型委托
        /// 延迟声明，推迟一切可以推迟的，事情能晚点就晚点。
        /// 泛型方法和普通方法性能差不多，可以用一个方法解决多个类型的问题
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="para"></param>
        public static void Show<T>(T para)
        {
            Console.WriteLine("This is {0}, Type is {1}", para, para.GetType().Name);
        }
    }
}
