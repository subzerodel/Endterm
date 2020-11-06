using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Week8Project.Core.Entities
{
    class Pricelist
    {
        [Key]
        public Guid Id { get; set; }

        public DateTime CreatedAt { get; set; }
        public List<PricelistItem> pricelistItems { get; set; }

    }
}
