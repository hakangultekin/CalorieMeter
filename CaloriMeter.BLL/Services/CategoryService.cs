using CaloriMeter.DAL.Repositories;
using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.BLL.Services
{
    public class CategoryService
    {
        CategoryRepository categoryRepository;

        public CategoryService()
        {
            categoryRepository = new CategoryRepository();
        }

        public List<Category> GetAll()
        {
            return categoryRepository.GetAll();
        }


        public bool Insert(Category entity)
        {
            if (CheckCategoryName(entity))
            {
                return categoryRepository.Insert(entity);
            }
            else throw new Exception("Categori Ad bilgisi eksik");
        }

        public bool Update(Category entity)
        {
            if (CheckCategoryName(entity))
            {
                return categoryRepository.Update(entity);
            }
            else throw new Exception("Categori bilgisi eksik");
        }

        public Category GetCategoryById(int id)
        {
            return categoryRepository.GetCategoryById(id);
        }

        bool CheckCategoryName(Category entity)
        {
            if (!string.IsNullOrWhiteSpace(entity.Name)) return true;
            else return false;
        }
    }
}
