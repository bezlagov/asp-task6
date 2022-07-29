using CalcServiceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace CalcServiceProject.Controllers
{
    public class CalcController : Controller
    {
        CalcService _calcService;
        public CalcController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public IActionResult Index(float result)
        {
            return View(result);
        }
        
        public IActionResult Sum(int a, int b)
        {
            return RedirectToAction("Index", new { result = _calcService.Sum(a,b) });
        }

        public IActionResult Div(int a, int b)
        {
            return RedirectToAction("Index", new { result = _calcService.Divide(a,b) });
        }

        public IActionResult Mul(int a, int b)
        {
            return RedirectToAction("Index", new { result = _calcService.Multiply(a, b) });
        }

        public IActionResult Sub(int a, int b)
        {
            return RedirectToAction("Index", new { result = _calcService.Subtract(a, b) });
        }
    }
}
