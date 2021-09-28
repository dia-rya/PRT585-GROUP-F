using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Blog
    {
        public Int64 BlogID { get; set; } //(PK)
        public String Blog_Name { get; set; }
    }
}
