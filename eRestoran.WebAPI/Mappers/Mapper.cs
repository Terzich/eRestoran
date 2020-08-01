using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Mappers
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<Database.User, Model.User>().ForMember(dest=> dest.City, opt=> opt.MapFrom(src=>src.City));
            CreateMap<Database.User, Model.Request.UserInsertRequest>().ReverseMap();

        }
    }
}
