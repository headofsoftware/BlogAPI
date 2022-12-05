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
    public class EfBlogRepository : EFGenericRepository<Blog>, IBlogDAL
    {
        public List<Blog> LastBlogs()
        {
            using var c = new Context();
            var values = c.Blogs.OrderByDescending(b=>b.BLogCreateDate).Take(3).ToList();
            return values;
        }

        public List<Blog> TopBlogs()
        {
            using var c = new Context();
            var values = c.Blogs.OrderByDescending(b => b.ClickCount).Take(3).ToList();
            return values;
        }
    }
}
