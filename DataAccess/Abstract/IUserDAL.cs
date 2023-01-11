using Entity.Concrete;
using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IUserDAL : IGenericDAL<User>
    {
        User LoginDAL(LoginDTO user); 
    }
}
