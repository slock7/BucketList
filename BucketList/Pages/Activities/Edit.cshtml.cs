using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucketList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BucketList.Pages.Activities
{
    public class EditModel : PageModel
    {
        private IBucketData _bucketData;

        [BindProperty]
        public BucketData BucketData { get; set; }

        public EditModel(IBucketData bucketData)
        {
            _bucketData = bucketData;
        }

        public IActionResult OnGet(int id)
        {
            BucketData = _bucketData.Get(id);

            if (BucketData == null)
            {
                return RedirectToAction("Index", "Home");
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _bucketData.Update(BucketData);

                RedirectToAction("Index", "Home");
                //RedirectToAction("Details", "Home", new { id = BucketData.Id});
                
            }
            return Page();
        }
    }
}