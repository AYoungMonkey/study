using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConsoleApp.Study.Attribute.Extend;
using ConsoleApp.Study.Attribute.VaildateExtend;

namespace ConsoleApp.Study.Attribute
{
    /// <summary>
    /// 
    /// 1 特性Attribute,和注释有什么区别
    ///     
    /// 2 声明和使用Attribute,AttributeUsage
    /// 3 运行中获取Attribute:额外的信息 额外操作
    /// 4 Remark封装、Attribute验证
    /// 
    /// 
    /// 特性：
    ///      MVC-EF-WCF-IOC 无处不在
    /// 特性可以影响编译器编译,还可以增加额外的功能
    /// [Obsolete("timeout")] 系统提示
    /// [Serializable] 序列化反序列化
    /// 
    /// 特性其实就是一个类，需要直接继承/间接继承 Attribute父类
    /// 声明特性的时候，约定俗称以Attribute结尾
    /// 
    /// 在标记的时候以中括号包裹，可以标记在元素上面
    /// [AttributeUsage(AttributeTargets.Class | AttributeTargets.Field,AllowMultiple = true)]
    /// AttributeTargets.All 设置标记的元素 class,method,field等,可以选择多个元素类型 建议明确标记元素
    /// AllowMultiple = true 是否可以重复标记
    /// 
    /// Obsolete Serializable 系统实现的，可以影响编译器，我们无法实现
    /// 
    /// 通过反编译工具可以看到： 标记了特性的元素，都会在元素内部生成.custom，但是C#不能在元素内部调用
    /// 
    /// 框架中如何使用特性？ 反射
    /// 反射可以调用特性，但是需要一个第三方类
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Student student1 = new StudentTwo() { 
                Id = 1,
                Name = "ABC",
                Group = "A Group"
            };

            InvokeCenter.ManagerStudent<Student>(student1);

            
            UserState userState = UserState.Normal;  //通过枚举在页面展示文字描述
            if (userState == UserState.Normal)
            {
                Console.WriteLine("正常状态");
            }
            else if (userState == UserState.Frozen)
            {
                Console.WriteLine("已冻结");
            }
            /// ....
            /// 如果发生修改，改动量变大
            
            // 通过特性获取额外信息
            string str = Extend.AttributeExtend.GetRemark(UserState.Normal);
            string str1 = UserState.Frozen.GetRemark(); // 扩展方法

            // 特性增加额外方法
            StudentTwo student2 = new StudentTwo()
            {
                Id = 2,
                Name = "BBB",
                Salary = 1000
            };

            VaildateExtend.AttributeExtend.validate(student2);
            VaildateExtend.AttributeExtend.validate<StudentTwo>(student2);

            student2.validate();
            student2.validate<StudentTwo>();
        }
    }
}
