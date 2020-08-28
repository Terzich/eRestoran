using AutoMapper;
using eRestoran.WebAPI.Database;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eRestoran.WebAPI.Services
{
    public class RecommendService:IRecommendService
    {
        protected eRestoranContext db;
        protected IMapper _mapper;

        public RecommendService(eRestoranContext context, IMapper mapper)
        {
            db = context;
            _mapper = mapper;
        }

        public List<Model.RestaurantMenuItem> RecommendProduct(int mtvs)
        {
            var x = LoadSimilar(mtvs);
            return _mapper.Map<List<Model.RestaurantMenuItem>>(x);
        }

        Dictionary<int, List<Database.MenuItemsReview>> rmItems = new Dictionary<int, List<Database.MenuItemsReview>>();

        public List<Database.RestaurantMenuItem> LoadSimilar(int titleId)
        {
            LoadItems(titleId);
            List<Database.MenuItemsReview> ratingsOfThis = db.MenuItemsReview.Where(x => x.RestaurantMenuItemId == titleId).OrderBy(x => x.UserId).ToList();

            List<Database.MenuItemsReview> ratings1 = new List<Database.MenuItemsReview>();
            List<Database.MenuItemsReview> ratings2 = new List<Database.MenuItemsReview>();
            List<Database.RestaurantMenuItem> recomendedMovies = new List<Database.RestaurantMenuItem>();

            foreach (var item in rmItems)
            {
                foreach (Database.MenuItemsReview rating in ratingsOfThis)
                {
                    if (item.Value.Where(x => x.UserId== rating.UserId).Count() > 0)
                    {
                        ratings1.Add(rating);
                        ratings2.Add(item.Value.Where(x => x.UserId == rating.UserId).First());
                    }
                }
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recomendedMovies.Add(db.RestaurantMenuItem.Where(x => x.RestaurantMenuItemId == item.Key).FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }

            return recomendedMovies;
        }

        private double GetSimilarity(List<Database.MenuItemsReview> ratings1, List<Database.MenuItemsReview> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x = Convert.ToDouble(ratings1[i].Grade) * Convert.ToDouble(ratings2[i].Grade);
                y1 = Convert.ToDouble(ratings1[i].Grade) * Convert.ToDouble(ratings2[i].Grade);
                y2 = Convert.ToDouble(ratings2[i].Grade) * Convert.ToDouble(ratings2[i].Grade);
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }

        private void LoadItems(int mtvsId)
        {
            Database.RestaurantMenuItem r = db.RestaurantMenuItem.Find(mtvsId);
            List<Database.RestaurantMenuItem> mtvs = db.RestaurantMenuItem.Where(x => x.RestaurantMenuItemId != mtvsId && x.ItemCategoryId==r.ItemCategoryId).ToList();
            List<Database.MenuItemsReview> ratings = new List<Database.MenuItemsReview>();
            foreach (Database.RestaurantMenuItem item in mtvs)
            {
                ratings = db.MenuItemsReview.Include(x => x.User).Where(x => x.RestaurantMenuItemId == item.RestaurantMenuItemId).OrderBy(x => x.UserId).ToList();
                if (ratings.Count > 0)
                    rmItems.Add(item.RestaurantMenuItemId, ratings);
            }
        }


    }
}
