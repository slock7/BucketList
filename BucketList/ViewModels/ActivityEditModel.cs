using System.ComponentModel.DataAnnotations;
using BucketList.Models;

namespace BucketList.ViewModels
{
    public class ActivityEditModel
    {
        [Required, MaxLength(80)]
        public string Activity { get; set; }

        public ActivityType ActivityType { get; set; }
    }
}
