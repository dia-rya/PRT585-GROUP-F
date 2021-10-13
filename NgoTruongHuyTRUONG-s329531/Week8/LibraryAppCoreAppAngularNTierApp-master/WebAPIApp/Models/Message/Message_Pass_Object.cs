using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_API.Models.Message
{
    public class Message_Pass_Object
    {
        public int id { get; set; } 
        public String content { get; set; }
        public String status { get; set; }
        public String creationDate { get; set; }
        public String sentDate { get; set; }
        public String modifiedDate { get; set; }

    }
}
