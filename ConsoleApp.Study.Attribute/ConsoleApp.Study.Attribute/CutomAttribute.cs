using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Attribute
{
    [AttributeUsage(AttributeTargets.All,AllowMultiple = true)]
    public class CutomAttribute : System.Attribute
    {
        //public CutomAttribute()
        //{
        //    Console.WriteLine("无参构造函数");
        //}

        public CutomAttribute(int i)
        {
            Console.WriteLine("Int类型构造函数");
        }

        public CutomAttribute(int i, string s)
        {
            Console.WriteLine("两个参数构造函数");
        }

        public string Remark { get; set; }

        public string Description;

        public void show()
        {
            Console.WriteLine("通过反射调用特性中的方法");
        }

    }

    public class CutomAttributeChild : CutomAttribute
    {
        // 子类无法初始化父类构造函数，会报错
        public CutomAttributeChild() : base(123)
        { 
        
        }
    }

}
