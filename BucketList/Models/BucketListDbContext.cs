using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BucketList.Models
{
    public class BucketListDbContext : DbContext
    {
        public BucketListDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<BucketData> BucketDatas { get; set; }
    }
}
