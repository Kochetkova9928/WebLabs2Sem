using Microsoft.AspNetCore.Mvc;
using WebLabs.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLabs.Controllers
{
    public class CalcController : Controller
    {
        private const int secretToken = 55;


        public IActionResult ManualSingle()
        {
            if (Request.Method.ToLower() == "post")
            {
                return FormHadler();
            }
            return View();
        }

        [HttpGet]
        public IActionResult ManualSeparate()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ManualSeparate(int token)
        {
            if (token != secretToken)
            {
                return Forbid();
            }
            return FormHadler();
        }

        public IActionResult FormHadler()
        {
            var num1String = Request.Form.FirstOrDefault(p => p.Key == "num1").Value;
            var num1 = Int32.Parse(num1String);

            var num2String = Request.Form.FirstOrDefault(p => p.Key == "num2").Value;
            var num2 = Int32.Parse(num2String);

            var operationString = Request.Form.FirstOrDefault(p => p.Key == "operation").Value;
            var operationInt = Int32.Parse(operationString);
            var operation = (Operation)operationInt;


            return View("Result", new ResultModel(num1, num2, operation));
        }

        [HttpGet]
        public IActionResult ModelParameters()
        {
            return View(new CalcModel());
        }

        [HttpPost]
        public IActionResult ModelParameters(CalcModel model)
        {
            return View("Result", new ResultModel(model));
        }

        [HttpGet]
        public IActionResult ModelSeparate(int token)
        {
            return View(new CalcModel());
        }

        [HttpPost]
        public IActionResult ModelSeparate(CalcModel model)
        {
            return View("Result", new ResultModel(model));
        }
    }
}
