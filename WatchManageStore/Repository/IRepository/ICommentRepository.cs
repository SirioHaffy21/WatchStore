using System.Collections.Generic;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Repository.IRepository
{
    public interface ICommentRepository : IBaseRepository<Comment>
    {
        IList<Comment> GetCommentsForPost(int postId);
        void AddComment(Comment comment);
        IList<Comment> GetAllComments();
        public void DeleteById(int id);
    }
}
