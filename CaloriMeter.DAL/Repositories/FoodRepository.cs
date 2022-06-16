using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.Repositories
{
    public class FoodRepository
    {
        CalorieMeterDbContext db;
        public FoodRepository()
        {
            db = new CalorieMeterDbContext();
        }

        /// <summary>
        /// Bütün yemekleri gösterir.
        /// </summary>
        /// <returns></returns>
        public List<Food> GetAll()
        {
            return db.Foods.ToList();
        }

        /// <summary>
        /// Kullanıcının eklediği yemekler ve adminin eklediği yemekleri gösterir.
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Food> GetAllByUser(int userid)
        {
            return db.Foods.Where(x => x.UserID == 0 && x.UserID == userid).ToList();
        }

        public List<Food> FindFood(string word)
        {
            return db.Foods.Where(x => x.Name.Contains(word)).ToList();
        }

        public List<Food> FindFoodByUser(int userid ,string word)
        {
            return db.Foods.Where(x => x.Name.Contains(word) && x.UserID == userid).ToList();
        }

        public bool Insert(Food food)
        {
            db.Foods.Add(food);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(Food food)
        {
            Food updatedFood = db.Foods.SingleOrDefault(x => x.FoodID == food.FoodID);
            updatedFood.Name = food.Name;
            updatedFood.CategoryID = food.CategoryID;
            updatedFood.PortionSize = food.PortionSize;
            updatedFood.Per100grCal = food.Per100grCal;
            updatedFood.State = food.State;
            updatedFood.Grams = food.Grams;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool DelistFood(int foodid)
        {
            Food food = db.Foods.SingleOrDefault(x => x.FoodID == foodid);
            food.State = false;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }
    }
}
