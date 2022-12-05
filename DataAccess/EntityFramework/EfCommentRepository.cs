using DataAccess.Abstract;
using DataAccess.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityFramework
{
    public class EfCommentRepository : EFGenericRepository<Comment>, ICommentDAL
    {
        public List<Comment> CommentsByUserID(int id)
        {
            using var c = new Context();
            var values = c.Comments.Where(c => c.UserID == id).ToList();
            return values;
        }

        public List<Comment> CommentsByBlogID(int id)
        {
            using var c = new Context();
            var values = c.Comments.Where(c => c.BlogID == id).ToList();
            return values;
        }
    }
}
