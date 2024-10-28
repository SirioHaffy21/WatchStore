using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using WatchManageStore.Areas.Admin.Common;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;
using WatchManageStore.Repository.IRepository;
using WatchManageStore.Services;

namespace WatchManageStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class WatchController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IWebHostEnvironment _enviroment;
        private readonly IRateAccountRepository _repository;
        private readonly AdminWatchService _adminWatchService;
        public WatchController(IUnitOfWork unitOfWork, IMapper mapper,
            IWebHostEnvironment enviroment,IRateAccountRepository repository)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _enviroment = enviroment;
            _repository = repository;
            _adminWatchService = new AdminWatchService(_unitOfWork);
        }
        public IActionResult Index()
        {
            var result = _unitOfWork.watchRepository.GetAll();
            ViewBag.Categorites = _unitOfWork.categoryRepository.GetAll();
            ViewBag.Bands = _unitOfWork.brandRepository.GetAll();
            ViewBag.Stores = _unitOfWork.storeRepository.GetAll();
            return View(result);
        }
        public IActionResult Create(WatchRequest request)
        {
            var watch = _mapper.Map<Watch>(request);
            var detailWatch = _mapper.Map<DetailWatch>(request);

            //xu ly file ảnh
            if (request.File != null)
            {
                var fileName = request.File.FileName.ToString().Split('.')[0];
                var fileNameConvert = UrlHepler.FrientlyUrl(fileName) + ".png";
                watch.Image = fileNameConvert;
                string path = "imgs/";
                path += fileNameConvert;
                string webRootPath = Path.Combine(_enviroment.WebRootPath, path);
                //luu vao server
                request.File.CopyTo(new FileStream(webRootPath, FileMode.Create));
            }
            //check update hay create 
            //update
            if (request.WatchId != 0)
            {
                watch.ModifyDate = DateTime.Now;

                _unitOfWork.watchRepository.Update(watch);
                detailWatch.WatchID = watch.WatchId;
                _unitOfWork.detailWatchRepository.Update(detailWatch);
                _unitOfWork.SaveChanges();
                TempData["Update"] = "Update Success!";
                return RedirectToAction(nameof(Index));
            }
            watch.CreateOn = DateTime.Now;
            var watchId = _adminWatchService.SaveWatch(watch);
            TempData["Create"] = "Create Success!";
            detailWatch.WatchID = watchId;

            if (detailWatch.Diameter != 0)
            {
                _unitOfWork.detailWatchRepository.Add(detailWatch);
                _unitOfWork.SaveChanges();
              
            }
            return RedirectToAction(nameof(Index));
        }
        public ActionResult GetDetail(int id)
        {
            var watch = _unitOfWork.watchRepository.Find(x => x.WatchId == id);
            var rate = _repository.RateAverageWatch(id);
            return Json(new { watch = watch,rate=Math.Round(rate,0) });
        }
        public ActionResult Delete(int id)
        {
            try
            {
                var watch = _unitOfWork.watchRepository.Find(x => x.WatchId == id);
                _unitOfWork.watchRepository.Delete(watch);
                var detailWatch = _unitOfWork.detailWatchRepository.Find(x => x.Id == watch.WatchId);
                _unitOfWork.detailWatchRepository.Delete(detailWatch);
                _unitOfWork.SaveChanges();
                TempData["Delete"] = "Delete Success!";
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    public class WatchRequest
    {
        public int WatchId { get; set; }
        public int Id { get; set; }
        public string WatchName { get; set; }
        public bool Status { get; set; }
        public string Description { get; set; }
        public IFormFile File { get; set; }
        public string Image { get; set; }
        public double Price { get; set; }
        public DateTime CreateOn { get; set; }
        public DateTime ModifyDate { get; set; }
        public DateTime InsuranceDate { get; set; }
        public int CategoryId { get; set; }
        public int StoreId { get; set; }
        public int BrandId { get; set; }
        public int Diameter { get; set; }//đường kính
        public bool Waterproof { get; set; } //chống nước
        public string Facematerial { get; set; } //chất liệu mặt
        public string WireMaterial { get; set; } //chất liệu dây
        public string Style { get; set; } //kiểu dáng .nam/nữ
        public string Warranty { get; set; } // chế độ bảo hành, mấy năm

    }
}
