using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Model
{
    public class User : BaseModel
    {
        public string Name { get; set; }

        public string Account { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public string Mobile { get; set; }

        public int CommpanyId { get; set; }
    }
}
