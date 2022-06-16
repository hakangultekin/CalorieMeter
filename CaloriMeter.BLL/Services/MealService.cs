using CaloriMeter.DAL.Repositories;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.BLL.Services
{
    public class MealService
    {
        MealRepository mealRepository;
        public MealService()
        {
            mealRepository = new MealRepository();
        }

        public List<Meal> GetAll()
        {
            return mealRepository.GetAll();
        }

        /// <summary>
        /// Kullanıcının bütün öğünlerini getirir
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Meal> GetUserMeals(int userid)
        {
            return mealRepository.GetUserMeals(userid);
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
            TarihKontrol(baslangic, bitis);
            return mealRepository.GetUserMeals(userid, baslangic, bitis);
        }

        /// <summary>
        /// Verilen kategorideki bütün öğün detaylarını getirir. Öğünleri içerisindeki detaylarda arama yapar.
        /// </summary>
        /// <param name="categoryId"></param>
        /// <returns></returns>
        public List<MealDetail> GetAllByCategory(int categoryId)
        {
            return mealRepository.GetAllByCategory(categoryId);
        }

        public List<MealDetail> GetAllByCategory(int categoryId, DateTime baslangic, DateTime bitis)
        {
            return mealRepository.GetAllByCategory(categoryId, baslangic, bitis);
        }

        /// <summary>
        /// Yeni öğün ekler.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public bool Insert(Meal entity)
        {
            MealDetailControl(entity.MealDetails);
            if (entity.RegisterationDate == null) throw new Exception("Tarih alanı boş olamaz.");
            return mealRepository.Insert(entity);
        }

        /// <summary>
        /// Var olan mealı günceller.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public bool Update(Meal entity)
        {
            MealDetailControl(entity.MealDetails);
            return mealRepository.Update(entity);
        }

        /// <summary>
        /// Kullanıcının öğününü siler.
        /// </summary>
        /// <param name="mealId"></param>
        /// <returns></returns>
        public bool Delete(int mealId)
        {
            return mealRepository.Delete(mealId);
        }

        void TarihKontrol(DateTime baslangic, DateTime bitis)
        {
            if (bitis < baslangic) throw new Exception("Bitiş tarihi başlangıç tarihinden küçük olamaz.");
        }

        void MealDetailControl(ICollection<MealDetail> mealDetails)
        {
            foreach (MealDetail item in mealDetails)
            {
                if (item.FoodID <= 0) throw new Exception("Food girişi hatalı.");
                if (item.Calory <= 0) throw new Exception("Kalori bilgisi hatalı.");
                if (item.Grams <= 0) throw new Exception("Gram bilgisi hatalı");
            }
        }
    }
}
