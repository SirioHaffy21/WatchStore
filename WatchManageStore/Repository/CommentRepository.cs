using System.Collections.Generic;
using System.Linq;
using WatchManageStore.Data;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;

namespace WatchManageStore.Repository
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        private readonly ApplicationDBContext _context;

        public CommentRepository(ApplicationDBContext context) : base(context)
        {
            _context = context;
        }

        public void AddComment(Comment comment)
        {
            _context.Add(comment);
            _context.SaveChanges();
        }
        public IList<Comment> GetAllComments()
        {
            return _context.Comments.ToList();
        }

        public IList<Comment> GetCommentsForPost(int postId)
        {
            return _context.Comments.Where(item => item.Post.PostId.Equals(postId)).ToList();

        }
        public void DeleteById(int id)
        {
            var comment = _context.Comments.Find(id);
            _context.Comments.Remove(comment);
        }
    }
}
