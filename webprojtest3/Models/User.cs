using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webprojtest3.Models
{
    public class User
    {
        public string UserID { get; set; }
        public string f_Name { get; set; }
        public string l_Name { get; set; }
        public string email { get; set; }
        public string phone_No { get; set; }
        public string emergency_Contact_Name { get; set; }
        public string emergency_Contact_No { get; set; }

        public DateTime login_Time { get; set; }

        public string user_Type { get; set; }


    }
}
