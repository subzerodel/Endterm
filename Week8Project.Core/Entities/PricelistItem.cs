
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
namespace Week8Project.Core.Entities
{
    class PricelistItem
    {
        [Key]
        public Guid Id { get; set; }

        public decimal Price { get; set; }

        public Guid PricelistId { get; set; }
        public Pricelist pricelist { get; set; }

        public Guid ProductId { get; set; }
        public Product product { get; set; }
    }
}
