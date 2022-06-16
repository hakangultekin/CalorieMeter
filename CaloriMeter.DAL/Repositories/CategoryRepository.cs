using CaloriMeter.Model.Entitites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaloriMeter.DAL.Repositories
{
    public class CategoryRepository
    {
        CalorieMeterDbContext db;
        public CategoryRepository()
        {
            db = new CalorieMeterDbContext();
        }

        public List<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public bool Insert(Category entity)
        {
            db.Categories.Add(entity);
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public bool Update(Category entity)
        {
            Category updatedCategory = db.Categories.SingleOrDefault(x => x.CategoryID == entity.CategoryID);
            updatedCategory.Name = entity.Name;
            int affRows = db.SaveChanges();
            return affRows > 0;
        }

        public List<Category> FindCategory(string word)
        {
            return db.Categories.Where(x => x.Name.Contains(word)).ToList();
        }
    }
}
