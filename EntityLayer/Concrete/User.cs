using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class User
    {
        [Key]
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Mail { get; set; }
        public string UserAbout { get; set; }
        public string UserImage { get; set; }
        public bool UserStatus { get; set; }
        public bool Role { get; set; } // 0 equal Reader and 1 equal Writer.




    }
}
