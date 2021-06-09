using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using webprojtest3.Models;

namespace webprojtest3.Data
{
    public class DbInitializer
    {
        public static void Initialize(GymContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
           //  new Student{UserID = "231341", StudentID="00001", f_Name="Waldo",l_Name="Wagan",email = "test@gmail.com", phone_No = "021093293", emergency_Contact_Name="Jacy", emergency_Contact_No = "0219329", login_Time=DateTime.Now, membership_Start = DateTime.Parse("2002-09-01"), membership_End = DateTime.Parse("2002-10-01"), payment = false },
           //  new Student{UserID = "231341", StudentID="00002", f_Name="Waldo",l_Name="Wagan",email = "test@gmail.com", phone_No = "021093293", emergency_Contact_Name="Jacy", emergency_Contact_No = "0219329", login_Time=DateTime.Now, membership_Start = DateTime.Parse("2002-09-01"), membership_End = DateTime.Parse("2002-10-01"), payment = false }
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var staff = new Staff[]
            {
               // new Staff{UserID = "11111", StaffID="00001", f_Name="Waldo",l_Name="Wagan",email = "test@gmail.com", phone_No = "021093293", emergency_Contact_Name="Cambell", emergency_Contact_No = "0219329", user_Type = "Staff", login_Time=DateTime.Now},
               //  new Staff{UserID = "11112", StaffID="00002", f_Name="Walter",l_Name="White",email = "test@gmail.com", phone_No = "021093293", emergency_Contact_Name="Cambell", emergency_Contact_No = "0219329", user_Type = "Staff", login_Time=DateTime.Now}
            };
        
            foreach (Staff st in staff)
            {
                context.Staff.Add(st);
            }
            context.SaveChanges();

        }
    }
}
