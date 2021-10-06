using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    public class Message
    {
        public Int64 MessageID { get; set; } //(PK)
        public String Message_Content { get; set; }
        public String Message_Status { get; set; }
        public String Message_Creation_Date { get; set; }
        public String Message_Sent_Date { get; set; }
        public String Message_Modified_Date { get; set; }
    }
}
