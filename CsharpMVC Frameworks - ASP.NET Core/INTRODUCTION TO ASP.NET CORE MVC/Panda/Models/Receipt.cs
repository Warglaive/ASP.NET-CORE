using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Panda.Models
{
    public class Receipt
    {
        [Key]
        public string Id { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Fee { get; set; }
        public DateTime IssuedOn { get; set; }

        public User Recipient { get; set; }
        public string RecipientId { get; set; }

        public Package Package { get; set; }
        public string PackageId { get; set; }
    }
}