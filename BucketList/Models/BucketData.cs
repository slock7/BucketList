using System;
using System.ComponentModel.DataAnnotations;

namespace BucketList.Models
{
    public class BucketData
    {
        public int Id { get; set; }

        [Display(Name = "Activity Name")]
        [Required, MaxLength(80)]
        public string Activity { get; set; }
        public ActivityType ActivityType { get; set; }
        public string Status { get; set; }
        //public DateTime DateTo { get; set; }
    }
}