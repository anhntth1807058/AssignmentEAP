using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AssignmentMVC.Models
{
    public class Markets
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public MarketStatus Status { get; set; }
        public virtual ICollection<Coins> Coins { get; set; }
        public enum MarketStatus
        {
            Active = 1,
            Deactive = 0,
            Delete = -1
        }
        internal bool IsDeleted()
        {
            return this.Status == MarketStatus.Delete;
        }
    }
}