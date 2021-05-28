using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Study.Attribute.VaildateExtend
{
    [AttributeUsage(AttributeTargets.Property)]
    public class SalaryAttribute : AbstratValidateAttribute
    {
        public SalaryAttribute(long Salary)
        {
            this._Salary = Salary;
        }
        public long _Salary { get; set; }

        public override bool Validate(object oValue)
        {
            if (oValue != null && long.TryParse(oValue.ToString(), out long lValue) && lValue < _Salary)
            {
                return true;
            }
            else {
                return false;
            }
        }
    }
}
