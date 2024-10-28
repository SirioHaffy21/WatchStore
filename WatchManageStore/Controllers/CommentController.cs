using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Controllers
{
    public class CommentController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CommentController(IUnitOfWork unitOfWork, IMapper mapper):base(unitOfWork,mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        // GET: CommentController

        [HttpGet]
        public ActionResult GetCommentForPost(int id)
        {
            var listVM = new List<CommentVM>();
            var result = _unitOfWork.commentRepository.GetCommentsForPost(id).ToList();
           
            for(int i = 0; i < result.Count(); i++)
            {
                var vm = _mapper.Map<CommentVM>(result[i]);
                var account = _unitOfWork.accountRepository.Find(x => x.Id == result[i].UserId);
                vm.UserName = account.UserName;
                listVM.Add(vm);
            }
            
            return Json(new { code = 200, lst = listVM });
        }
        // GET: CommentController/Details/5
        [HttpPost]
        public ActionResult Create(string comment,int id,int rate)
        { 
            Comment cm = new Comment();
            cm.Content = comment;
            cm.PostId = id;
            RateAccount rateAccount = new RateAccount();
            rateAccount.PostId = id;
            rateAccount.Rate = rate;

            //gan cung thong tin
            cm.UserId = HttpContext.User?.FindFirst(ClaimTypes.NameIdentifier).Value;
            _unitOfWork.rateAccountRepository.Add(rateAccount);
            _unitOfWork.commentRepository.AddComment(cm);
            //_unitOfWork.commentRepository.Add(comment);
            return Json(new { code = 200, msg = "Thêm thành công" });
        }
      
    }
}
