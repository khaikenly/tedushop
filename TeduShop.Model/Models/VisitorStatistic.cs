using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TeduShop.Model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public Guid ID { get; set; }
        [Required]
        public DateTime VisitedDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string IPAddress { get; set; }
    }
}
