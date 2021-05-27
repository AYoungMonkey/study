using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.SqlServer
{
    public class ReflectionTest
    {
        public ReflectionTest()
        {
            Console.WriteLine("这里是{0} 无参数构造函数", this.GetType().Name);
        }

        public ReflectionTest(string name)
        {
            Console.WriteLine("这里是{0} 有参数构造函数：{1}", this.GetType().Name, name);
        }

        public ReflectionTest(int number)
        {
            Console.WriteLine("这里是{0} 有参数构造函数：{1}", this.GetType().Name, number);
        }

        public void show1()
        {
            Console.WriteLine("这里是{0}的show1 无参数方法", this.GetType().Name);
        }

        public void show2(int number)
        {
            Console.WriteLine("这里是{0}的show2 有参数方法", this.GetType().Name);
        }

        public void show3(int number ,string name)
        {
            Console.WriteLine("这里是{0}的show3 有参数方法", this.GetType().Name);
        }

        public void show3(string name, int number)
        {
            Console.WriteLine("这里是{0}的show3 有参数方法", this.GetType().Name);
        }

        public void show3(int number)
        {
            Console.WriteLine("这里是{0}的show3 有参数方法", this.GetType().Name);
        }
        public void show3(string name)
        {
            Console.WriteLine("这里是{0}的show3 有参数方法", this.GetType().Name);
        }

        private void show4(string name)
        {
            Console.WriteLine("这里是{0}的show4 私有带参数方法", this.GetType().Name);
        }

        public static void show5(string name)
        {
            Console.WriteLine("这里是{0}的show5 有参数方法", typeof(ReflectionTest));
        }
    }
}

