using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Study.Attribute.VaildateExtend
{
    [AttributeUsage(AttributeTargets.Field)]
    public class LongAttribute : AbstratValidateAttribute
    {
        public long _Max { get; set; } 
        public long _Min { get; set; }

        public LongAttribute()
        {
            
        }

        public override bool Validate(object oValue)
        {
            if (oValue != null && oValue.ToString().Length >= _Min && oValue.ToString().Length <= _Max)
            {
                return true;
            }
            return false;
        }
    }
}
