using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Study.Model
{
    public class Company : BaseModel
    {
        public string Name { get; set; }

        public DateTime CreateTime { get; set; }

        public int CreatorId { get; set; }

        public int? LastModiffierId { get; set; }

        public DateTime? LastModifyTime { get; set; }
    }
}
