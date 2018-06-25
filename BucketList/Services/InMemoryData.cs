using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BucketList.Models
{
    //public class InMemoryData : IBucketData
    //{
    //    public InMemoryData()
    //    {
    //        _bucket = new List<BucketData>
    //        {
    //            new BucketData { Id = 1, Activity = "Bungee jumping", Status = "not completed"} ,
    //            new BucketData { Id = 2, Activity = "F1 driving", Status = "not completed"} ,
    //            new BucketData { Id = 3, Activity = "Scubadiving in the Great Reef", Status = "not completed"}
    //        };
    //    }

    //    List<BucketData> _bucket;

    //    public IEnumerable<BucketData> GetAll()
    //    {
    //        return _bucket.OrderBy(b => b.Activity);
    //    }

    //    public BucketData Get(int id)
    //    {
    //        return _bucket.FirstOrDefault(b => b.Id == id);
    //    }

    //    public BucketData Add(BucketData activity)
    //    {
    //        activity.Id = _bucket.Max(b => b.Id) + 1;
    //        _bucket.Add(activity);
    //        return activity;
    //    }
    //}
}
