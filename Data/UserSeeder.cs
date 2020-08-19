using Eon_TestAssignment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Eon_TestAssignment.Data
{
    public class UserSeeder
    {
        public UserSeeder(UserContext dbcontext)
        {
            User user1 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Peter Even",
                Email = "pet@gmail.com",
                Gender = "M",
                RegisteredDate = "2/3/2019",
                SelectedDays = "Day1",
                AddRequest = "To provide rooms"
            };
            dbcontext.Add(user1);

            User user2 = new User()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Wutt Yee",
                Email = "wuttyee@gmail.com",
                Gender = "F",
                RegisteredDate = "2/5/2019",
                SelectedDays = "Day2",
                AddRequest = "Meeting"
            };
            dbcontext.Add(user2);
            dbcontext.SaveChanges();
        }
    }
}
