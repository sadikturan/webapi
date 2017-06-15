using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Entity
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Name is required.")]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [Range(1, 5000)]
        public decimal Price { get; set; }

        public bool isApproved { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
