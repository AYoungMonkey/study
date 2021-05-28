using ConsoleApp.Study.Attribute.VaildateExtend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Attribute
{
    [Cutom(123,Remark = "ClassRemark",Description = "ClassDescription")]
    public class StudentTwo : Student
    {
        [Cutom(123, Remark = "PropRemark", Description = "PropDescription")]
        public string Group { get; set; }

        [Cutom(123, Remark = "PropRemark", Description = "PropDescription")]
        public void Homework()
        {
            Console.WriteLine("Homework");
        }
        [SalaryAttribute(800)]
        public int Salary { get; set; }

        [LongAttribute(_Max = 11, _Min = 5)]
        public long QQ;
    }
}
