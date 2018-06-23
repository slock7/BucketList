using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BucketList.Models;

namespace BucketList.Services
{
    public class SqlBucketData : IBucketData
    {
        private BucketListDbContext _context;

        public SqlBucketData(BucketListDbContext context)
        {
            _context = context;
        }

        public IEnumerable<BucketData> GetAll()
        {
            return _context.BucketDatas.OrderBy(b => b.Id);
        }

        public BucketData Get(int id)
        {
            return _context.BucketDatas.FirstOrDefault(b => b.Id == id);
        }

        public BucketData Add(BucketData newActivity)
        {
            _context.BucketDatas.Add(newActivity);
            _context.SaveChanges();

            return newActivity;
        }
    }
}
