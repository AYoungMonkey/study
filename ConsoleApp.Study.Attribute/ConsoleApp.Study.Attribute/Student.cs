using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Attribute
{
    [Obsolete("timeout")]
    [Serializable]
    [Cutom(123)]
    [Cutom(123,"AAA")]
    [Cutom(234,Remark = "Remark", Description = "Description")]
    [CutomAttributeChild]
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Cutom(123)]
        public void study()
        {
            Console.WriteLine($"这里是{this.Name}");
        }
        [return:Cutom(123), Cutom(345)]
        public string Answer([Cutom(123)] string name)
        {
            return $"this is {name}";
        }
    }
}
