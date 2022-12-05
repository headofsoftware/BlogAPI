using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EFCategoryRepository : EFGenericRepository<Category>, ICategoryDAL
    {
        public List<Category> LastCategories()
        {
            using var c = new Context();
            var values = c.Categories.OrderByDescending(b => b.CategoryCreateDate).Take(3).ToList();
            return values;
        }

        public List<Category> TopCategories()
        {
            using var c = new Context();
            var values = c.Categories.OrderByDescending(b => b.CategoryCreateDate).Take(3).ToList();
            return values; 
        }
    }
}
