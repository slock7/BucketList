using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucketList.Models;

namespace BucketList.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<BucketData> BucketDatas { get; set; }
        public string CurrentMessage { get; set; }
    }
}
