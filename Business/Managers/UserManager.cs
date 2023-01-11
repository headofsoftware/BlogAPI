using Business.Services;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity.DTO;
using Business.AutoMapper;
using AutoMapper;

namespace Business.Managers
{

    public class UserManager : IUserService
    {
        private readonly IUserDAL userDAL = new EFUserRepository();
        private readonly IMapper _mapper;

        public UserManager(IMapper mapper)
        {
            _mapper = mapper;
        }

        public UserManager()
        {
        }

        public IResult AddUser(User user)
        {
            userDAL.Insert(user);
            return new SuccessResult(ConstantsMessages.AddUser);
        }

        public IResult DeleteUser(User user)
        {
            userDAL.Delete(user);
            return new SuccessResult(ConstantsMessages.DeleteUser);
        }
        public IResult UpdateUser(User user)
        {
            userDAL.Update(user);
            return new SuccessResult(ConstantsMessages.UpdateUser);
        }

        public IDataResult<List<User>> GetListUser()
        {
            return new SuccessDataResult<List<User>>(userDAL.GetListAll());
        }

        public IDataResult<User> GetUser(int id)
        {
            return new SuccessDataResult<User>(userDAL.GetByID(id));
        }

       

        public LoginDTO Login(LoginDTO user)
        {
            var value = userDAL.LoginDAL(user);
            var result = _mapper.Map<LoginDTO>(value);
            return result;
        }
    }
}


