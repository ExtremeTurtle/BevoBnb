using System.ComponentModel.DataAnnotations;

namespace Group7FinalProject.Models
{
    public class Category
    {
        public Int32 CategoryID { get; set; }

        [Display(Name = "Category Name")]
        public String CategoryName { get; set; }

    }
}
