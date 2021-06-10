using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace webprojtest3.Models
{
    public class Client : User
    {
        public string ClientID { get; set; }
        public DateTime membership_start_client { get; set; }
        public DateTime membership_end_client { get; set; }
    }
}
