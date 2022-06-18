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
            return db.Foods.Where(x => x.UserID == 1 && x.UserID == userid && x.State == true).ToList();
        }

        public List<Food> FindFood(string word)
        {
            return db.Foods.Where(x => x.Name.Contains(word)).ToList();
        }

        public List<Food> FindFoodByUser(int userid ,string word)
        {
            return db.Foods.Where(x => x.Name.Contains(word) && x.UserID == 1 && x.UserID == userid && x.State == true).ToList();
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
            updatedFood.Per100Cal = food.Per100Cal;
            updatedFood.Grams = food.Grams;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        /// <summary>
        /// Verilen food'un state'ini false yaparak kullanıcıların listede görememesini sağlar. Delete mantığıyla çalışacak.
        /// </summary>
        /// <param name="foodid"></param>
        /// <returns></returns>
        public bool DelistFood(int foodid)
        {
            Food food = db.Foods.SingleOrDefault(x => x.FoodID == foodid);
            food.State = false;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }
    }
}
