using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface ICategoryService
    {
        IResult AddCategory(Category category);
        IResult DeleteCategory(Category category);
        IResult UpdateCategory(Category category);
        IDataResult<List<Category>> GetListCategory();
        IDataResult<Category> GetCategory(int id);
        IDataResult<List<Category>> GetTopCategory();
        IDataResult<List<Category>> GetLastCategory();
    }
}

