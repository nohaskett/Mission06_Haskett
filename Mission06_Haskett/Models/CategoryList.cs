using System.ComponentModel.DataAnnotations;

namespace Mission06_Haskett.Models
{
    public class CategoryList
    {
        [Key]
        public int CategoryId { get; set; }
        public string Category { get; set; }

    }
}
