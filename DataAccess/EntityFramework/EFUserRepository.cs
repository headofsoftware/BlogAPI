using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFUserRepository : EFGenericRepository<User>, IUserDAL
    {
        public User LoginDAL(LoginDTO user)
        {
            using var c = new Context();
            var value = c.Users.FirstOrDefault(u => u.Username == user.Username && u.Password == user.Password);
            return value;
        }

    }
}
