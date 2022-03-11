using Microsoft.AspNetCore.Mvc;
using WebLabs.Models;
using WebLabs.Services;
using System;

namespace WebLabs.Controllers
{
    public class CalcServiceController : Controller
    {

        private readonly CalcService _calcService;

        public CalcServiceController(CalcService calcService)
        {
            _calcService = calcService;
        }

        public ActionResult PassUsingModel()
        {
            var model = new PassUsingModel
            {
                Num1 = _calcService.Num1,
                Num2 = _calcService.Num2,
                Sum = _calcService.Sum,
                Sub = _calcService.Sub,
                Mul = _calcService.Mul,
                Div = _calcService.Div
            };

            return View(model);
        }

        public ActionResult PassUsingViewData()
        {
            ViewData["Num1"] = _calcService.Num1;
            ViewData["Num2"] = _calcService.Num2;
            ViewData["Sum"] = _calcService.Sum;
            ViewData["Sub"] = _calcService.Sub;
            ViewData["Mul"] = _calcService.Mul;
            ViewData["Div"] = _calcService.Div;

            return View();
        }

        public ActionResult PassUsingViewBag()
        {
            ViewBag.Num1 = _calcService.Num1;
            ViewBag.Num2 = _calcService.Num2;
            ViewBag.Sum = _calcService.Sum;
            ViewBag.Sub = _calcService.Sub;
            ViewBag.Mul = _calcService.Mul;
            ViewBag.Div = _calcService.Div;

            return View();
        }

        public ActionResult AccessServiceDirectly()
        {
            return View();
        }
    }
}
