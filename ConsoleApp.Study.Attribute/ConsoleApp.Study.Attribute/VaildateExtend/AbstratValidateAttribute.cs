using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Study.Attribute.VaildateExtend
{
    public abstract class AbstratValidateAttribute : System.Attribute
    {
        public abstract bool Validate(object oValue);
    }
}
