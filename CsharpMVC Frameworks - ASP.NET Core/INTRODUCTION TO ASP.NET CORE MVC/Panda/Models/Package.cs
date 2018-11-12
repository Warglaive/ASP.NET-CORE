using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Panda.Models.Enums;

namespace Panda.Models
{
    public class Package
    {
        [Key]
        public string Id { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Weight { get; set; }
        public string ShippingAddress { get; set; }
        public Status Status { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }

        public User Recipient { get; set; }
        public string RecipientId { get; set; }
    }
}