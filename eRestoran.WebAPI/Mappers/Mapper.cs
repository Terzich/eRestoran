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
            CreateMap<Database.SuperOffer, Model.SuperOffer>().ReverseMap();
            CreateMap<Database.SuperOffer, Model.Request.SuperOfferUpsertRequest>().ReverseMap();
            CreateMap<Database.Award, Model.Award>().ReverseMap();
            CreateMap<Database.Award, Model.Request.AwardUpsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Visitor>().ReverseMap();
            CreateMap<Database.UserRole, Model.VisitorRole>().ReverseMap();
            CreateMap<Database.DiscountType, Model.DiscountType>().ReverseMap();
            CreateMap<Database.Discount, Model.Discount>().ReverseMap();
            CreateMap<Database.Discount, Model.Request.DiscountUpsertRequest>().ReverseMap();
            CreateMap<Database.VisitorRecommendation, Model.VisitorRecommendation>().ReverseMap();
            CreateMap<Database.VisitorRecommendation, Model.Request.VisitorRecommendationUpsertRequest>().ReverseMap();
            CreateMap<Database.Visit, Model.Visit>().ReverseMap();
            CreateMap<Database.Visit, Model.Request.VisitUpsertRequest>().ReverseMap();
            CreateMap<Database.RestaurantReview, Model.RestaurantReview>().ReverseMap();
            CreateMap<Database.RestaurantReview, Model.Request.RestaurantReviewUpsertRequest>().ReverseMap();
            CreateMap<Database.City, Model.City>().ReverseMap();
            CreateMap<Database.MenuItemsReview, Model.MenuItemsReview>().ReverseMap();
            CreateMap<Database.MenuItemsReview, Model.Request.MenuItemsReviewUpsertRequest>().ReverseMap();







        }
    }
}
