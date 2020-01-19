using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace Core_WebApp.Models
{
    public class Category
    {
        [Key]
        public int CategoryRowID { get; set; }
        [Required(ErrorMessage ="CategoryID is requires")]
        public string CategoryID { get; set; }
        [Required(ErrorMessage ="Category Name is must")]
        public string CategoryName { get; set; }
        [Required(ErrorMessage ="Base price is must")]
        public int BasePrice { get; set; }

        public ICollection<Product> Products { set; get; }
    }
    public class Product
    {
        [Key]
        public int ProductRowID { get; set; }
        [Required(ErrorMessage ="Product ID is required")]
        public string ProductID { get; set; }
        [Required(ErrorMessage ="Product Name is must")]
        public string ProductName { get; set; }
        [Required(ErrorMessage = "Manufacturer is must")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Description is must")]
        public string Description { get; set; }
        [Required(ErrorMessage ="Category RowID is must")]
        public int CategoryRowID { get; set; }
        [Required (ErrorMessage ="Category is must")]
        public  Category Category { get; set; }
    }
}
