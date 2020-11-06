using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Week8Project.Core.Entities
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        public String Name { get; set; }
        public String Description { get; set; }
    }
}
