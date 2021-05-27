﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace ConsoleApp.Study.Attribute.Extend
{
    public static class AttributeExtend
    {
        public static string GetRemark(this Enum value)
        {

            Type type = value.GetType();
            FieldInfo field = type.GetField(value.ToString());
            if (field.IsDefined(typeof(RemarkAttribute), true))
            {
                RemarkAttribute attribute = (RemarkAttribute)field.GetCustomAttribute(typeof(RemarkAttribute), true);
                return attribute.Remark;
            }
            else {
                return value.ToString();
            }

        }
    }
}
