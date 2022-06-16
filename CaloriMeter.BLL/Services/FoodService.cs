using CaloriMeter.Model.Entitites;
using CaloriMeter.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.BLL.Services
{
    public class FoodService
    {
        FoodRepository foodRepository;
        public FoodService()
        {
            foodRepository = new FoodRepository();
        }

        /// <summary>
        /// Bütün yemekleri gösterir.
        /// </summary>
        /// <returns></returns>
        public List<Food> GetAll()
        {
            return foodRepository.GetAll();
        }

        /// <summary>
        /// Kullanıcının eklediği yemekler ve adminin eklediği yemekleri gösterir.
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public List<Food> GetAllByUser(int userid)
        {
            return foodRepository.GetAllByUser(userid);
        }

        /// <summary>
        /// Admin paneli için bütün yemekler içerisinde arama yapar.
        /// </summary>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<Food> FindFood(string word)
        {
            return foodRepository.FindFood(word);
        }

        /// <summary>
        /// Kullanıcı ekranında user arama yaparken kullanılacak. Sadece user'in eklediği ve adminin eklediği yemekleri arar.
        /// </summary>
        /// <param name="userid"></param>
        /// <param name="word"></param>
        /// <returns></returns>
        public List<Food> FindFoodByUser(int userid, string word)
        {
            return foodRepository.FindFoodByUser(userid, word);
        }

        /// <summary>
        /// Yeni yemek ekler.
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool Insert(Food food)
        {
            ControlBlanks(food);
            return foodRepository.Insert(food);
        }

        /// <summary>
        /// Var olan bir yemeği günceller
        /// </summary>
        /// <param name="food"></param>
        /// <returns></returns>
        public bool Update(Food food)
        {
            ControlBlanks(food);
            return foodRepository.Update(food);
        }

        public bool DelistFood(int foodid)
        {
            return foodRepository.DelistFood(foodid);
        }

        void ControlBlanks(Food food)
        {
            if (string.IsNullOrWhiteSpace(food.Name) || string.IsNullOrWhiteSpace(food.Grams.ToString()) || string.IsNullOrWhiteSpace(food.Per100grCal.ToString()) || string.IsNullOrWhiteSpace(food.CategoryID.ToString()) || string.IsNullOrWhiteSpace(food.UserID.ToString()) || string.IsNullOrWhiteSpace(food.PortionSize.ToString()))
                throw new Exception("Lütfen bütün alanları doldurunuz.");
        }

    }
}
