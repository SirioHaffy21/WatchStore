using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using WatchManageStore.Areas.Admin.Common;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BrandsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _enviroment;

        public BrandsController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnviroment)
        {
            _unitOfWork = unitOfWork;
            _enviroment = webHostEnviroment;
        }
        // GET: BrandsController
        public ActionResult Index()
        {
            var result = _unitOfWork.brandRepository.GetAll();
            return View(result);
        }

        // GET: BrandsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BrandsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BrandsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BrandRequest request)
        {
            try
            {
                var brand = new Brand();
                brand.BrandName = request.BrandName;
                if (request.File != null)
                {
                    var fileName = request.File.FileName.ToString().Split('.')[0];
                    var fileNameConvert = UrlHepler.FrientlyUrl(fileName) + ".png";
                    brand.Image = fileNameConvert;
                    string path = "imgs/";
                    path += fileNameConvert;
                    string webRootPath = Path.Combine(_enviroment.WebRootPath, path);
                    //luu vao server
                    request.File.CopyTo(new FileStream(webRootPath, FileMode.Create));
                }
                _unitOfWork.brandRepository.Add(brand);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BrandsController/Edit/5
        public ActionResult Edit(int id)
        {
            var result = _unitOfWork.brandRepository.Find(x => x.BrandId == id);
            return View(result);
        }

        // POST: BrandsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, BrandRequest request)
        {
            try
            {
                var brand = new Brand();
                brand.BrandId = request.BrandId;
                brand.BrandName = request.BrandName;
                brand.Image = request.Image;
                if (request.File != null)
                {
                    var fileName = request.File.FileName.ToString().Split('.')[0];
                    var fileNameConvert = UrlHepler.FrientlyUrl(fileName) + ".png";
                    brand.Image = fileNameConvert;
                    string path = "imgs/";
                    path += fileNameConvert;
                    string webRootPath = Path.Combine(_enviroment.WebRootPath, path);
                    //luu vao server
                    request.File.CopyTo(new FileStream(webRootPath, FileMode.Create));
                }
                _unitOfWork.brandRepository.Update(brand);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var brand = _unitOfWork.brandRepository.Find(x => x.BrandId == id);
                _unitOfWork.brandRepository.Delete(brand);
                _unitOfWork.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
    public class BrandRequest
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Image { get; set; }
        public IFormFile File { get; set; }
    }
}
