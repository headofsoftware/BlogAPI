using Business.Services;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDAL categoryDAL = new EFCategoryRepository();

        public IResult AddCategory(Category category)
        {
            categoryDAL.Insert(category);
            return new SuccessResult(ConstantsMessages.AddCategory);
        }

        public IResult DeleteCategory(Category category)
        {
            categoryDAL.Delete(category);
            return new SuccessResult(ConstantsMessages.DeleteBlog);
        }
        public IResult UpdateCategory(Category category)
        {
            categoryDAL.Update(category);
            return new SuccessResult(ConstantsMessages.UpdateCategory);
        }

        public IDataResult<Category> GetCategory(int id)
        {
            return new SuccessDataResult<Category>(categoryDAL.GetByID(id));
        }

        public IDataResult<List<Category>> GetLastCategory()
        {
            return new SuccessDataResult<List<Category>>(categoryDAL.LastCategories());
        }

        public IDataResult<List<Category>> GetListCategory()
        {
            return new SuccessDataResult<List<Category>>(categoryDAL.GetListAll());
        }

        public IDataResult<List<Category>> GetTopCategory()
        {
            return new SuccessDataResult<List<Category>>(categoryDAL.TopCategories());
        }

        
    }
}


