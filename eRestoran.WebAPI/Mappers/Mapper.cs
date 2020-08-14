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
            CreateMap<Database.Restaurant, Model.Restaurant>().ReverseMap();
            CreateMap<Database.Restaurant, Model.Request.RestaurantUpdateRequest>().ReverseMap();
            CreateMap<Database.ItemType, Model.ItemType>().ReverseMap();
            CreateMap<Database.ItemCategory, Model.ItemCategory>().ReverseMap();
            CreateMap<Database.Quantity, Model.Quantity>().ReverseMap();
            CreateMap<Database.RestaurantMenuItem, Model.RestaurantMenuItem>().ReverseMap();
            CreateMap<Model.RestaurantMenuItem, Model.Request.RestaurantMenuItemUpsertRequest>().ReverseMap();
            CreateMap<Database.RestaurantMenuItem, Model.Request.RestaurantMenuItemUpsertRequest>().ReverseMap();
            CreateMap<Database.Role, Model.Role>().ReverseMap();
            CreateMap<Database.UserRole, Model.UserRole>().ReverseMap();





        }
    }
}
