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
    public class CommentManager : ICommentService
    {
        private readonly ICommentDAL commentDAL = new EfCommentRepository();

        public IResult AddComment(Comment comment)
        {
            commentDAL.Insert(comment);
            return new SuccessResult(ConstantsMessages.AddComment);
        }

        public IResult DeleteComment(Comment comment)
        {
            commentDAL.Delete(comment);
            return new SuccessResult(ConstantsMessages.DeleteComment);
        }
        public IResult UpdateComment(Comment comment)
        {
            commentDAL.Update(comment);
            return new SuccessResult(ConstantsMessages.UpdateComment);
        }

        public IDataResult<Comment> GetComment(int id)
        {
            return new SuccessDataResult<Comment>(commentDAL.GetByID(id));
        }

        public IDataResult<List<Comment>> GetCommentByBlogID(int id)
        {
            return new SuccessDataResult<List<Comment>>(commentDAL.CommentsByBlogID(id));
        }

        public IDataResult<List<Comment>> GetCommentByUserID(int id)
        {
            return new SuccessDataResult<List<Comment>>(commentDAL.CommentsByUserID(id));
        }

        public IDataResult<List<Comment>> GetListComment()
        {
            return new SuccessDataResult<List<Comment>>(commentDAL.GetListAll());
        }

        
    }
}


