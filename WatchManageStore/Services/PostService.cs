using System.Collections.Generic;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Services.InterfaceServices;

namespace WatchManageStore.Services
{
    public class PostService: IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IList<Post> GetListPost()
        {
            return _unitOfWork.postRepository.GetAll();
        }
        public Post GetById(int id)
        {
            return _unitOfWork.postRepository.Find(x => x.PostId == id);
        }
    }
}
