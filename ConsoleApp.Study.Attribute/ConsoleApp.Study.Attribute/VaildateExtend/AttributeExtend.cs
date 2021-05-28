using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Study.Attribute.VaildateExtend
{
    public static class AttributeExtend
    {
        public static bool validate(this StudentTwo student)
        {
            Type type = student.GetType();
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AbstratValidateAttribute), true)) {

                    object ovalue = prop.GetValue(student);

                    object[] attributes = prop.GetCustomAttributes(typeof(AbstratValidateAttribute), true);
                    foreach (AbstratValidateAttribute attribute in attributes)
                    {

                        return attribute.Validate(ovalue);

                    }
                }
            }
            return false;
            
        }

        public static bool validate<T>(this T t) where T : class
        {
            Type type = t.GetType();
            foreach (PropertyInfo prop in type.GetProperties())
            {
                if (prop.IsDefined(typeof(AbstratValidateAttribute), true))
                {

                    object ovalue = prop.GetValue(t);

                    object[] attributes = prop.GetCustomAttributes(typeof(AbstratValidateAttribute), true);
                    foreach (AbstratValidateAttribute attribute in attributes)
                    {

                        if (!attribute.Validate(ovalue)) {
                            return false;
                        }

                    }
                }
            }

            foreach (FieldInfo prop in type.GetFields())
            {
                if (prop.IsDefined(typeof(AbstratValidateAttribute), true))
                {

                    object ovalue = prop.GetValue(t);

                    object[] attributes = prop.GetCustomAttributes(typeof(AbstratValidateAttribute), true);
                    foreach (AbstratValidateAttribute attribute in attributes)
                    {

                        if (!attribute.Validate(ovalue))
                        {
                            return false;
                        }

                    }
                }
            }
            return true;

        }
    }

    public static class AttributeLongExtend
    {
        //public static bool validate(this StudentTwo student)
        //{
        //    Type type = student.GetType();
        //    foreach (PropertyInfo prop in type.GetProperties())
        //    {
        //        if (prop.IsDefined(typeof(SalaryAttribute), true))
        //        {

        //            object ovalue = prop.GetValue(student);

        //            object[] attributes = prop.GetCustomAttributes(typeof(SalaryAttribute), true);
        //            foreach (SalaryAttribute attribute in attributes)
        //            {

        //                return attribute.Validate(ovalue);

        //            }
        //        }
        //    }
        //    return false;

        //}

        public static bool longvalidate<T>(this T t) where T : class
        {
            Type type = t.GetType();
            foreach (FieldInfo prop in type.GetFields())
            {
                if (prop.IsDefined(typeof(AbstratValidateAttribute), true))
                {

                    object ovalue = prop.GetValue(t);

                    object[] attributes = prop.GetCustomAttributes(typeof(AbstratValidateAttribute), true);
                    foreach (AbstratValidateAttribute attribute in attributes)
                    {

                        return attribute.Validate(ovalue);

                    }
                }
            }
            return false;

        }
    }
}
