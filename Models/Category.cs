using MyMvcApp.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyMvcApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [Required]
        [StringLength(50)]
        public string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
