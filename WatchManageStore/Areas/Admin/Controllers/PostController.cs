using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using WatchManageStore.Areas.Admin.Common;
using WatchManageStore.Areas.Admin.Models;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class PostController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _environment;

        public PostController(IUnitOfWork unitOfWork, IMapper mapper, IWebHostEnvironment environment)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _environment = environment;
        }
        // GET: PostController
        public ActionResult Index()
        {
            var result = _unitOfWork.postRepository.GetAll();
            var postvm = _mapper.Map<List<PostVM>>(result);
            return View(postvm);
        }

        // GET: PostController/Details/5
        public ActionResult Details(int id)
        {
            var result = _unitOfWork.postRepository.Find(x => x.PostId == id);
    
            var rate = _unitOfWork.rateAccountRepository.RateAveragePost(id);
            var postvm = _mapper.Map<PostVM>(result);
            postvm.Rate = rate;
            return View(postvm);
        }

        // GET: PostController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PostController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(PostRequest postVM)
        {
            try
            {
                var post = _mapper.Map<Post>(postVM);
                post.CreateOn = DateTime.Now;
                //lưu ảnh vào server
                if (postVM.Image != null)
                {
                    var fileName = postVM.Image.FileName.ToString().Split('.')[0];
                    var fileNameConvert = UrlHepler.FrientlyUrl(fileName) + ".png";
                    post.Image1 = fileNameConvert;
                    string path = "imgs/";
                    path += fileNameConvert;
                    string webRootPath = Path.Combine(_environment.WebRootPath, path);
                    //luu vao server
                    postVM.Image.CopyTo(new FileStream(webRootPath, FileMode.Create));
                }
                _unitOfWork.postRepository.Add(post);
                _unitOfWork.SaveChanges();
                TempData["Create"] = "Create Success!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PostController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _unitOfWork.postRepository.Find(x => x.PostId == id);
            return View(result);
        }

        // POST: PostController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, PostRequest postVM)
        {
            try
            {
                var post = _mapper.Map<Post>(postVM);
                var x = postVM;
                //neeus sua anh
                if(postVM.Image != null)
                {
                    var fileName = postVM.Image.FileName.ToString().Split('.')[0];
                    var fileNameConvert = UrlHepler.FrientlyUrl(fileName) + ".png";
                    post.Image1 = fileNameConvert;
                    string path = "imgs/";
                    path += fileNameConvert;
                    string webRootPath = Path.Combine(_environment.WebRootPath, path);
                    //luu vao server
                    postVM.Image.CopyTo(new FileStream(webRootPath, FileMode.Create));
                }
                post.ModifyDate = DateTime.Now;
                _unitOfWork.postRepository.Update(post);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //// GET: PostController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        public ActionResult Delete(int id)
        {
            try
            {
                _unitOfWork.postRepository.DeleteById(id);
                _unitOfWork.SaveChanges();
                TempData["Delete"] = "Delete Success!";
                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction(nameof(Index));
            }
        }
        public ActionResult DeleteComment(int id)
        {
            try
            {
                _unitOfWork.commentRepository.DeleteById(id);
                _unitOfWork.SaveChanges();
                //TempData["Delete"] = "Delete Success!";
                return Json(new { code = 200, msg = "Xóa thành công" });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return RedirectToAction(nameof(Index));
            }
        }
    }
    public class PostRequest
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool Status { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public IFormFile Image { get; set; }
        public DateTime CreateOn { get; set; }
    }
}
