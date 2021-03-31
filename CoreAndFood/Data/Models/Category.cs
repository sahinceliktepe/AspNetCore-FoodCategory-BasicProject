using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage ="Category name cannot be empty")]
        [StringLength(20, ErrorMessage ="Please enter maximum 20 and minimum 4 characters", MinimumLength =4)]
        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }
        public bool Status { get; set; }
        public List<Food> Foods { get; set; }
    }
}
