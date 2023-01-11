using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IUserService
    {
        IResult AddUser(User user);
        IResult DeleteUser(User user);
        IResult UpdateUser(User user);
        IDataResult<List<User>> GetListUser();
        IDataResult<User> GetUser(int id);
        LoginDTO Login(LoginDTO user);
    }
}

