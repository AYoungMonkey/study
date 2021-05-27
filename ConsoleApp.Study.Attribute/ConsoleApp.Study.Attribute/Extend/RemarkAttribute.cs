using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Attribute.Extend
{
    [AttributeUsage(AttributeTargets.Field)]
    public class RemarkAttribute :System.Attribute
    {
        public RemarkAttribute(string remark)
        {
            this.Remark = remark;
        }

        public string Remark { get; private set; }
    }
}
