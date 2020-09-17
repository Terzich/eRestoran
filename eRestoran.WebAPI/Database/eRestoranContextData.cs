using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using eRestoran.WebAPI.Helper;
using Microsoft.EntityFrameworkCore;

namespace eRestoran.WebAPI.Database
{
    public partial class eRestoranContext
    {
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId=1,
                RoleName="Administrator"
            });

            modelBuilder.Entity<Role>().HasData(new Role()
            {
                RoleId=2,
                RoleName = "Visitor"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId=1,
                CityName="Bugojno"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 2,
                CityName = "Mostar"
            }); 
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 3,
                CityName = "Sarajevo"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 4,
                CityName = "Donji Vakuf"
            });
            modelBuilder.Entity<City>().HasData(new City()
            {
                CityId = 5,
                CityName = "Tuzla"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId=1,
                Description="Popust na svu hranu"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 2,
                Description = "Popust na sva pića"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 3,
                Description = "Popust na predjela"

            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 4,
                Description = "Popust na glavna jela"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 5,
                Description = "Popust na mesne plate"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 6,
                Description = "Popust na salate"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 7,
                Description = "Popust na deserte"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 8,
                Description = "Popust na negazirane sokove"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 9,
                Description = "Popust na gazirane sokove"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 10,
                Description = "Popust na cijeđene sokove"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 11,
                Description = "Popust na vodu"
            });
            modelBuilder.Entity<DiscountType>().HasData(new DiscountType()
            {
                DiscountTypeId = 12,
                Description = "Popust na pojedinačnu stavku"
            });
            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                GenderId=1,
                Gender1 = "Muško"
            });
            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                GenderId = 2,
                Gender1 = "Žensko"
            });
            modelBuilder.Entity<Gender>().HasData(new Gender()
            {
                GenderId = 3,
                Gender1 = "Ne želim reći"
            });
            modelBuilder.Entity<ItemType>().HasData(new ItemType()
            {
                ItemTypeId=1,
                Type="Hrana"
            });
            modelBuilder.Entity<ItemType>().HasData(new ItemType()
            {
                ItemTypeId = 2,
                Type = "Pića"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId=1,
                ItemTypeId=1,
                Category="Predjela"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 2,
                ItemTypeId = 1,
                Category = "Glavna jela"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 3,
                ItemTypeId = 1,
                Category = "Deserti"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 5,
                ItemTypeId = 1,
                Category = "Salate"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 6,
                ItemTypeId = 1,
                Category = "Mesne plate"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 7,
                ItemTypeId = 2,
                Category = "Negazirani sokovi"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 8,
                ItemTypeId = 2,
                Category = "Gazirani sokovi"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 10,
                ItemTypeId = 2,
                Category = "Cijeđeni sokovi"
            });
            modelBuilder.Entity<ItemCategory>().HasData(new ItemCategory()
            {
                ItemCategoryId = 11,
                ItemTypeId = 2,
                Category = "Voda"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId=1,
                Description= "Đački (5 komada)",
                Mark= "ĆE"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 2,
                Description = "Mali (10 komada)",
                Mark = "ĆE"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 3,
                Description = "Srednji (15 komada)",
                Mark = "ĆE"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 4,
                Description = "Veliki (20 komada)",
                Mark = "ĆE"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 5,
                Description = "Mala",
                Mark = "PI"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 6,
                Description = "Srednja",
                Mark = "PI"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 7,
                Description = "Velika",
                Mark = "PI"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 8,
                Description = "Male",
                Mark = "PLj-SU"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 9,
                Description = "Velike",
                Mark = "PLj-SU"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 10,
                Description = "1 komad",
                Mark = "KOL"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 11,
                Description = "0,25L",
                Mark = "SOK"
            });
            modelBuilder.Entity<Quantity>().HasData(new Quantity()
            {
                QuantityId = 12,
                Description = "0,5L",
                Mark = "VOD"
            });
            modelBuilder.Entity<Restaurant>().HasData(new Restaurant()
            {
                RestaurantId = 1,
                RestaurantName = "Restoran FIT",
                CityId = 2,
                Address = "Sjeverni logor, broj 8",
                NumberOfTables = 15,
                OpenAt = new DateTime(2020, 08, 11, 08, 00, 00),
                CloseAt= new DateTime(2020, 08, 11, 22, 00, 00),
                Image=File.ReadAllBytes("img/restaurant.jpg")
    
            }) ;
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId=1,
                ItemName="Ćevapi",
                Price=5,
                ItemCategoryId=2,
                QuantityId=2,
                Image= File.ReadAllBytes("img/chevapi.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 2,
                ItemName = "Cijeđena narandža",
                Price = 3,
                ItemCategoryId = 10,
                QuantityId = 12,
                Image = File.ReadAllBytes("img/cnarana.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 3,
                ItemName = "Mesna plata (Classic)",
                Price = 17,
                ItemCategoryId = 6,
                QuantityId = 6,
                Image = File.ReadAllBytes("img/mplata.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 4,
                ItemName = "Pizza Margherita",
                Price = 4,
                ItemCategoryId = 2,
                QuantityId = 5,
                Image = File.ReadAllBytes("img/pizzam.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 5,
                ItemName = "Nutella torta",
                Price = 3,
                ItemCategoryId = 3,
                QuantityId = 10,
                Image = File.ReadAllBytes("img/nutellac.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 6,
                ItemName = "Cheesecake",
                Price = 3,
                ItemCategoryId = 3,
                QuantityId = 10,
                Image = File.ReadAllBytes("img/cheesecake.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 7,
                ItemName = "Paradajz juha",
                Price = 3,
                ItemCategoryId = 1,
                QuantityId = 6,
                Image = File.ReadAllBytes("img/pjuha.jpg")
            });
            modelBuilder.Entity<RestaurantMenuItem>().HasData(new RestaurantMenuItem()
            {
                RestaurantMenuItemId = 8,
                ItemName = "Omlet",
                Price = 2,
                ItemCategoryId = 1,
                QuantityId = 10,
                Image = File.ReadAllBytes("img/omlet.jpg")
            });

            //desktop

            User u1 = new User
            {
                UserId = 1,
                Name = "Desktop",
                Surname = "User",
                DateOfBirth = new DateTime(1999, 01, 13),
                CityId = 4,
                Address = "Prusac b.b.",
                PhoneNumber = "062357889",
                GenderId = 1,
                Username = "desktop"
            };
            u1.PasswordSalt = HashGenerator.GenerateSalt();
            u1.PasswordHash = HashGenerator.GenerateHash(u1.PasswordSalt, "test");
            modelBuilder.Entity<User>().HasData(u1);


            //visitor

            User u2 = new User
            {
                UserId = 2,
                Name = "Mobile",
                Surname = "User",
                DateOfBirth = new DateTime(1999, 02, 21),
                CityId = 5,
                Address = "Mobilna br. 4",
                PhoneNumber = "062907219",
                GenderId = 1,
                Username = "mobile"
            };
            u2.PasswordSalt = HashGenerator.GenerateSalt();
            u2.PasswordHash = HashGenerator.GenerateHash(u2.PasswordSalt, "test");
            modelBuilder.Entity<User>().HasData(u2);

            modelBuilder.Entity<UserRole>().HasData(new UserRole()
            {
                UserRoleId=1,
                UserId=1,
                RoleId=1
            });
            modelBuilder.Entity<UserRole>().HasData(new UserRole()
            {
                UserRoleId = 2,
                UserId = 2,
                RoleId = 2
            });

            modelBuilder.Entity<Award>().HasData(new Award()
            {
                AwardId = 1,
                UserId=2,
                Description = "Besplatan bilo koji proizvod iz kategorije glavnih jela",
                Active = true,
                AwardDate = new DateTime(2020, 05, 06, 09, 00, 00)
            });

            modelBuilder.Entity<Discount>().HasData(new Discount()
            {
                DiscountId = 1,
                UserId = 2,
                DiscountTypeId=1,
                ItemTypeId=1,
                DiscountDate= new DateTime(2020, 05, 06, 09, 00, 00),
                Active = true,
                DiscountValue=Convert.ToDecimal(0.20)
            });
            modelBuilder.Entity<MenuItemsReview>().HasData(new MenuItemsReview()
            {
                MenuItemsReviewId = 1,
                UserId = 2,
                RestaurantMenuItemId = 1,
                Description="Jako ukusni ćevapi. Lepina bi samo mogla biti malo sočnija, sve u svemu super!",
                Grade=4
                
            });
            modelBuilder.Entity<RestaurantReview>().HasData(new RestaurantReview()
            {
                RestaurantReviewId=1,
                UserId=2,
                Description="Sve najbolje za restoran. Vrlo ljubazno osoblje i ugodan ambijent!",
                Grade=5
                
            });
            modelBuilder.Entity<Visit>().HasData(new Visit()
            {
                VisitId=1,
                UserId=2,
                DateOfVisit= new DateTime(2020, 05, 06, 09, 00, 00)

            });
            modelBuilder.Entity<Visit>().HasData(new Visit()
            {
                VisitId = 2,
                UserId = 2,
                DateOfVisit = new DateTime(2020, 06, 07, 19, 20, 00)

            });
            modelBuilder.Entity<VisitorRecommendation>().HasData(new VisitorRecommendation()
            {
               VisitorRecommendationId=1,
               UserId=2,
               RecommendationDescription="Preporuka za promjenu muzike, ova je dosta monotona"

            });
            modelBuilder.Entity<Key>().HasData(new Key()
            {
                KeyId=1,
               Key1=123456789,
               Active=true
            });
            modelBuilder.Entity<Key>().HasData(new Key()
            {
                KeyId = 2,

                Key1 = 987654321,
                Active = true
            });
            modelBuilder.Entity<Key>().HasData(new Key()
            {
                KeyId = 3,

                Key1 = 123789456,
                Active = true
            });
            modelBuilder.Entity<Key>().HasData(new Key()
            {
                KeyId = 4,

                Key1 = 789123456,
                Active = true
            });
            modelBuilder.Entity<Key>().HasData(new Key()
            {
                KeyId = 5,

                Key1 = 258963147,
                Active = true
            });
            modelBuilder.Entity<Key>().HasData(new Key()
            {
                KeyId = 6,

                Key1 = 147258369,
                Active = true
            });
        }
    }
}
