using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BucketList.Models
{
    public interface IBucketData
    {
        IEnumerable<BucketData> GetAll();
        BucketData Get(int id);
        BucketData Add(BucketData newActivity);
    }
}
