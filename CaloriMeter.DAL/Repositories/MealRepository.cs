using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.Repositories
{
    public class MealRepository
    {
        CalorieMeterDbContext db;
        public MealRepository()
        {
            db = new CalorieMeterDbContext();
        }

        public Meal GetMealByID(int id)
        {
            return db.Meals.Find(id);
        }

        public List<Meal> GetAll()
        {
            return db.Meals.Where(x => x.State ==true).ToList();
        }

        public List<Meal> GetAll(DateTime baslangic, DateTime bitis)
        {
            return db.Meals.Where(x => x.State == true && x.RegisterationDate >= baslangic && x.RegisterationDate <= bitis).ToList();
        }

        /// <summary>
        /// Kullanıcının bütün öğünlerini getirir
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Meal> GetUserMeals(int userid)
        {
            return db.Meals.Where(x => x.State == true && x.UserID == userid).ToList();
        }

        /// <summary>
        /// Tarihe göre kullanıcının öğünlerini getirir.
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="baslangic"></param>
        /// <param name="bitis"></param>
        /// <returns></returns>
        public List<Meal> GetUserMeals(int userid, DateTime baslangic, DateTime bitis)
        {
            return db.Meals.Where(x => x.State == true && x.UserID == userid && x.RegisterationDate >= baslangic && x.RegisterationDate <= bitis).ToList();
        }

        public List<MealDetail> GetAllByCategory(int categoryId)
        {
            return db.MealDetails.Where(x => x.Meal.State == true && x.Food.CategoryID == categoryId).ToList();
        }

        public List<MealDetail> GetAllByCategory(int categoryId, DateTime baslangic, DateTime bitis)
        {
            return db.MealDetails.Where(x => x.Meal.State == true && x.Food.CategoryID == categoryId && x.Meal.RegisterationDate >= baslangic && x.Meal.RegisterationDate <= bitis).ToList();
        }

        public bool Insert(Meal entity)
        {
            //Meal meal = new Meal() { };
            //meal.RegisterationDate = entity.RegisterationDate;
            //meal.UserID = entity.UserID;
            //meal.MealTypeID = entity.MealTypeID;
            //meal.State = entity.State;

            //Meal newMeal = db.Meals.Add(meal);
            //int affRows = db.SaveChanges();

            //newMeal.MealDetails = entity.MealDetails;
            //affRows = db.SaveChanges();

            db.Meals.Add(entity);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(Meal entity)
        {
            Meal updatedMeal = db.Meals.SingleOrDefault(x => x.MealID == entity.MealID);
            updatedMeal = entity;

            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Delete(int mealId)
        {
            Meal deletedMeal = db.Meals.Find(mealId);
            deletedMeal.State = false;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }
    }
}
