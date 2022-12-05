using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICategoryDAL : IGenericDAL<Category>
    {
        List<Category> LastCategories(); //Most Populer 3 categories.
        List<Category> TopCategories(); // Last Upload 3 categories.
    }
}