using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace webprojtest3.Models
{
    public class Student : User
    {
       // [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string StudentID { get; set; }
        public DateTime membership_Start { get; set; }
        public DateTime membership_End { get; set; }
        public bool payment { get; set; }

    }
}
