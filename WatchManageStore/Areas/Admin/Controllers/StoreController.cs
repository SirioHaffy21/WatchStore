using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.IO;
using WatchManageStore.Areas.Admin.Common;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Services;
namespace WatchManageStore.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class StoreController : Controller
    {
        private readonly AdminStoreService _adminStoreService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IMapper _mapper;

        public StoreController(IUnitOfWork unitOfWork, IWebHostEnvironment environment,
            IMapper mapper)
        {
            _adminStoreService = new AdminStoreService(unitOfWork);
            _unitOfWork = unitOfWork;
            _webHostEnvironment = environment;
           _mapper = mapper;
        }
        public IActionResult Index()
        {
            //var result = _adminStoreService.GetListStore();
            return View();
        }
        public JsonResult GetAll()
        {
            var result = _adminStoreService.GetListStore();
            return Json(new { success = true, code = 200, ds = result });
        }
        public JsonResult GetDetail(int id)
        {
            Store result = _adminStoreService.GetById(id);
            var numberRate = _unitOfWork.rateAccountRepository.RateAverageStore(result.StoreId);
            var VM = _mapper.Map<StoreDetailVM>(result);
            VM.Rate = numberRate;
            return Json(new {  detail = VM });
        }
        public ActionResult Delete(int id)
        {
            _unitOfWork.storeRepository.DelById(id);
            _unitOfWork.SaveChanges();
            TempData["Delete"] = "Delete Success!";

            return RedirectToAction(nameof(Index));
        }
        public IActionResult Create(RequestStore requestStore)
        {
            var store = new Store();
            store.StoreName = requestStore.StoreName;
            store.Status = requestStore.Status;
            store.Address = requestStore.Address;
            store.Phone = requestStore.Phone;
            store.Description = requestStore.Description;
         
            //gán tên image
            if (requestStore.Image != null)
            {
                // lưu tên ảnh theo tên của store
                store.Image = UrlHepler.FrientlyUrl(requestStore.StoreName) + ".png";
            }
            else
            {
                store.Image = requestStore.ImageData;
            }
            //lưu ảnh vào server
            if (requestStore.Image != null)
            {
                var fileName = requestStore.Image.FileName.ToString().Split('.')[0];
                var fileNameConvert = UrlHepler.FrientlyUrl(fileName) + ".png";
                // lưu tên ảnh theo tên của store
                store.Image = fileNameConvert;
                string path = "imgs/";
                //  path += UrlHepler.FrientlyUrl(store.StoreName)+ requestStore.Image.FileName;
                path += fileNameConvert;
                string webRootPath = Path.Combine(_webHostEnvironment.WebRootPath, path);
                requestStore.Image.CopyTo(new FileStream(webRootPath, FileMode.Create));
            }

            //update
            if (requestStore.StoreId != 0)
            {
                store.ModifyDate = DateTime.Now;
                store.StoreId = requestStore.StoreId;
                _unitOfWork.storeRepository.Update(store);
                _unitOfWork.SaveChanges();
                TempData["Update"] = "Update Success!";
                return RedirectToAction(nameof(Index));
            }
            //create
            store.CreateOn=DateTime.Now;
            _unitOfWork.storeRepository.Add(store);
            _unitOfWork.SaveChanges();
            TempData["Create"] = "Create Success!";
            return RedirectToAction(nameof(Index));
        }
    }
    public class RequestStore
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public bool Status { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public IFormFile Image { get; set; }
        public string ImageData { get; set; }
        public double Rate { get; set; }
    }
    public class StoreDetailVM
    {
   
        public int StoreId { get; set; }
        [MaxLength(50)]
        public string StoreName { get; set; }
        public bool Status { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Image { get; set; }
        public double Rate { get; set; }

    }
}
