using Microsoft.AspNetCore.Mvc;
using Task6.Models;

namespace Task6.Controllers
{
    public class StringTaskController : Controller
    {
        private IDay _dayService;
        private IMonth _monthService;
        public StringTaskController(IDay dayService, IMonth monthService)
        {
            _dayService = dayService;
            _monthService = monthService;
        }

        public IActionResult Index()
        {
            ViewBag.Days = _dayService.GetDays();
            ViewBag.Months = _monthService.GetMonths();
            return View();
        }
    }
}
