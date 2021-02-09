using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PublicApi.UserEndPoints
{
    public class UserDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public int Password { get; set; }
        public DateTime Date { get; set; }
    }
}
