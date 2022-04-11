using Microsoft.AspNetCore.Mvc;
using WebLabs.Models;

namespace WebLabs.Controllers
{
    public class ControlsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult TextBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextBox(TextBoxModel model)
        {
            return View("Result", new ResultModel(model));
        }


        [HttpGet]
        public IActionResult TextArea()
        {
            return View();
        }

        [HttpPost]
        public IActionResult TextArea(TextAreaModel model)
        {
            return View("Result", new ResultModel(model));
        }


        [HttpGet]
        public IActionResult CheckBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckBox(CheckBoxModel model)
        {
            return View("Result", new ResultModel(model));
        }


        [HttpGet]
        public IActionResult Radio()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Radio(RadioModel model)
        {
            return View("Result", new ResultModel(model));
        }


        [HttpGet]
        public IActionResult DropDownList()
        {
            return View();
        }

        [HttpPost]
        public IActionResult DropDownList(DropDownListModel model)
        {
            return View("Result", new ResultModel(model));
        }


        [HttpGet]
        public IActionResult ListBox()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ListBox(ListBoxModel model)
        {
            return View("Result", new ResultModel(model));
        }
    }
}
