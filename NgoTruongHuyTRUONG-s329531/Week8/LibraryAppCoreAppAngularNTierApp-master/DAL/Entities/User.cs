using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class User
    {
        public Int64 UserID { get; set; } //(PK)
        public String User_Name { get; set; }
        public String User_Password { get; set; }
        public String User_Profile_Name { get; set; }
        public String User_Email { get; set; }
        public String User_Creation_Date { get; set; }
        
    }
}
