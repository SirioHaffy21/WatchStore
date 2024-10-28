using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WatchManageStore.Infrastructure;
using WatchManageStore.Models;

namespace WatchManageStore.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        public HomeController(IUnitOfWork unitOfWork,IMapper mapper):base(unitOfWork,mapper)
        { 
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Cuahang()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
