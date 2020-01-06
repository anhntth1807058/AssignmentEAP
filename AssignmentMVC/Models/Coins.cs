using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AssignmentMVC.Models
{
    public class Coins
    {
        [Key]
        public string Code { get; set; }
        [Required]
        public string BaseAsset { get; set; }
        [Required]
        public string QuoteAsset { get; set; }
        [Required]
        public decimal LastPrice { get; set; }
        [Required]
        public int Volumn24h { get; set; }
        [ForeignKey("Market")]
        public int MarketId { get; set; }
        public virtual Markets Market { get; set; }
        public CoinStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public enum CoinStatus
        {
            Active = 1,
            Deactive = 0,
            Delete = -1
        }

        internal bool IsDeleted()
        {
            return this.Status == CoinStatus.Delete;
        }
    }
}