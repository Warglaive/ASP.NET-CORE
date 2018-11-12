using System;
using System.ComponentModel.DataAnnotations;

namespace Panda.Models
{
    public class Receipt
    {
        [Key]
        public string Id { get; set; }
        public decimal Fee { get; set; }
        public DateTime IssuedOn { get; set; }

        public User Recipient { get; set; }
        public string RecipientId { get; set; }

        public Package Package { get; set; }
        public string PackageId { get; set; }
    }
}