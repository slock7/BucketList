using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucketList.Models;
using BucketList.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration;

namespace BucketList.Controllers
{
    public class HomeController : Controller
    {
        private IBucketData _bucketData;
        private IGreeter _greeter;

        public HomeController(IBucketData bucketData, IGreeter greeter)
        {
            _bucketData = bucketData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.BucketDatas = _bucketData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();


            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _bucketData.Get(id);
            if (model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ActivityEditModel model)
        {
            if (ModelState.IsValid)
            {
                var newActivity = new BucketData();
                newActivity.Activity = model.Activity;
                newActivity.ActivityType = model.ActivityType;
                newActivity.DateAdded = DateTime.Now;

                newActivity = _bucketData.Add(newActivity);

                return RedirectToAction(nameof(Details), new {id = newActivity.Id});
            }
            else
            {
                return View();
            }
        }

    }
}