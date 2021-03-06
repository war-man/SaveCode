using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RicoCore.Infrastructure.SharedKernel;

namespace RicoCore.Data.Entities.ECommerce
{
    [Table("EComProductRelateds")]
    public class ProductRelated : DomainEntity<Guid>
    {
        [Required]
        public Guid ProductId { set; get; }

        [Required]
        public Guid RelatedId { set; get; }
    }
}