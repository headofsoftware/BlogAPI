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
    public class BlogManager : IBlogService
    {

        private readonly IBlogDAL blogDAL = new EfBlogRepository();

        public IResult AddBlog(Blog blog)
        {
            blogDAL.Insert(blog);
            return new SuccessResult(ConstantsMessages.AddBlog);
        }

        public IResult DeleteBlog(Blog blog)
        {
            blogDAL.Delete(blog);
            return new SuccessResult(ConstantsMessages.DeleteBlog);
        }


        public IDataResult<Blog> GetBlog(int id)
        {
            return new SuccessDataResult<Blog>(blogDAL.GetByID(id));
        }

        public IDataResult<List<Blog>> GetLastBlogs()
        {
            return new SuccessDataResult<List<Blog>>(blogDAL.LastBlogs());
        }

        public IDataResult<List<Blog>> GetListBlog()
        {
            return new SuccessDataResult<List<Blog>>(blogDAL.GetListAll());
        }

        public IDataResult<List<Blog>> GetTopBlogs()
        {
            return new SuccessDataResult<List<Blog>>(blogDAL.TopBlogs());
        }

        public IResult UpdateBlog(Blog blog)
        {
            return new SuccessResult(ConstantsMessages.UpdateBlog);
        }
    }
}



