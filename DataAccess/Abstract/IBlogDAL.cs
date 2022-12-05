using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IBlogDAL : IGenericDAL<Blog>
    {
        List<Blog> TopBlogs(); //Most Populer 3 blogs.
        List<Blog> LastBlogs(); //Last Upload 3 blogs.
    }
}
