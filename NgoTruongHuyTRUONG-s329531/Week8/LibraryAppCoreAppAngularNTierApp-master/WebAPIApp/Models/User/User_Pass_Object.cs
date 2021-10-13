using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Models.User
{
    public class User_Pass_Object
    {
        public int id { get; set; } 
        public String userName { get; set; }
        public String password { get; set; }
        public String profileName { get; set; }
        public String email { get; set; }
        public String creationDate { get; set; }

    }
}
