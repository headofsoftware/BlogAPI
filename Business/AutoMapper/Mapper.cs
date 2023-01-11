using AutoMapper;
using Core.Entities.Concrete;
using Entity.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.AutoMapper
{
    public class Mapper : Profile
    {
        protected Mapper()
        {
            CreateMap<User, LoginDTO>();
        }
    }
}
