using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Services;

namespace WatchManageStore.Controllers
{

    public class PostsController : BaseController
    {
        private readonly PostService _postService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;


        public PostsController(IUnitOfWork unitOfWork, IMapper mapper) :base(unitOfWork,mapper)
        {
            _unitOfWork = unitOfWork;
            _postService = new PostService(_unitOfWork);
            _mapper = mapper;
        }

        // GET: Posts
        public IActionResult Index()
        {
            var result = _postService.GetListPost();
            var postvm = _mapper.Map<List<PostVM>>(result);
            return View(postvm.OrderByDescending(x=>x.CreateOn));
        }

        [HttpGet]
        public IActionResult Details(int postId)
        {
            var post = _unitOfWork.postRepository.GetDetail(postId);
            if (post != null)
            {
                var res = _unitOfWork.postRepository.Find(x => x.PostId == postId);
                var rate = _unitOfWork.rateAccountRepository.RateAveragePost(postId);
                var postvm = _mapper.Map<PostVM>(res);
                postvm.Rate = rate;
                return View(postvm);
            }

            return View("_NotFound");

        }
        public IActionResult SearchPosts(string search)
        {

            var list = _unitOfWork.postRepository.GetAll().ToList();
            if (search == null)
            {
                return Json(new { searchItem = list });

            }
            if (string.IsNullOrEmpty(search))
            {
                return Json(new { searchItem = list });
            }
            var result = list.Where(x => x.Title.ToLower().Contains(search.ToLower())).ToList();
  
            //search rỗng 
            //null
            //list 

            return Json(new { searchItem = result });
            // return View();
        }

    }
}
