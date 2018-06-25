using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BucketList.Pages
{
    public class greetingModel : PageModel
    {
        private IGreeter _greeter;

        public string CurrentGreeting { get; set; }

        public greetingModel(IGreeter greeter)
        {
            _greeter = greeter;
        }
        public void OnGet()
        {
            CurrentGreeting = _greeter.GetMessageOfTheDay();
        }
    }
}