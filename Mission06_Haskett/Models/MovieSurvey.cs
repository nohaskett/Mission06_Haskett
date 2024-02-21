using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Haskett.Models
{
    public class MovieSurvey
    {
        [Key]
        [Required] // This parameter means that the applicaiton will break if it is not included. But I account for this as well in the actual form on the client side.
        public int MovieId { get ; set; } // Getters and setters for each table attribute

        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; } // Need to fix this to be category ID, not category
        public Category? Category { get; set; }
        public string? Title { get; set; }
        
        public int Year { get; set; }
        
        public string? Director { get; set; }
        
        public string? Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        
        public int CopiedToPlex { get; set; }
        [MaxLength(25)] // Client Side entry validation
        [StringLength(25)] // Server side entry validation
        public string? Notes { get; set; } // ? parameter allows the field to be null. though a string attribute already has the option to be null
    }
}
