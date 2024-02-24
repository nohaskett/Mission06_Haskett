using System.ComponentModel.DataAnnotations;

namespace Mission06_Haskett.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } // Use the actual name of the table column

    }
}
