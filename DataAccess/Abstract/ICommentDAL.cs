using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICommentDAL : IGenericDAL<Comment>
    {
        List<Comment> CommentsByBlogID(int id);

        List<Comment> CommentsByUserID(int id);


    }
}
