using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public interface IBlogService
    {

        IDataResult<Blog> GetBlog(int id);
        IResult AddBlog(Blog blog);
        IResult DeleteBlog(Blog blog);
        IResult UpdateBlog(Blog blog);
        IDataResult<List<Blog>> GetListBlog();
        IDataResult<List<Blog>> GetTopBlogs();
        IDataResult<List<Blog>> GetLastBlogs();
    }
}
