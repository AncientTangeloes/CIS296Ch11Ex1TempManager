using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;

namespace TempManager.Models
{
    public class Temp
    {
        public int Id { get; set; }
        [Remote("CheckDate", "Validation")]
        public DateTime? Date { get; set; }
        [Required]
        [Range (-200, 200)]
        public double? Low { get; set; }
        [Required]
        public double? High { get; set; }
    }
}
