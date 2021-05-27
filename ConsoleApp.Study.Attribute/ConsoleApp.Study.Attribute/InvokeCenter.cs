using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp.Study.Attribute
{
    public class InvokeCenter
    {
        public static void ManagerStudent<T>(T student) where T : Student
        {
            Console.WriteLine(student.Id);
            Console.WriteLine(student.Name);
            student.Answer("AAA");

            Type type = student.GetType();
            if (type.IsDefined(typeof(CutomAttribute), true))
            {
                Object[] attributsArr = type.GetCustomAttributes(typeof(CutomAttribute), true);
                foreach (CutomAttribute attribut in attributsArr)
                {
                    attribut.show();
                }

                foreach (PropertyInfo property in type.GetProperties())
                {
                    if(property.IsDefined(typeof(CutomAttribute), true))
                    {
                        object[] propAttributsArr = property.GetCustomAttributes(typeof(CutomAttribute), true);
                        foreach (CutomAttribute propAttribut in propAttributsArr)
                        {
                            propAttribut.show();
                        }
                    }
                }

                foreach (MethodInfo method in type.GetMethods())
                {
                    if (method.IsDefined(typeof(CutomAttribute), true))
                    {
                        object[] methodAttributsArr = method.GetCustomAttributes(typeof(CutomAttribute), true);
                        foreach (CutomAttribute methodAttribut in methodAttributsArr)
                        {
                            methodAttribut.show();
                        }
                    }
                }
            }
        }
    }
}
