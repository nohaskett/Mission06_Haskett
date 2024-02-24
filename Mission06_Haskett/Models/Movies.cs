using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Haskett.Models
{
    public class Movies
    {
        [Key]
        [Required] // This parameter means that the applicaiton will break if it is not included. But I account for this as well in the actual form on the client side.
        public int MovieId { get ; set; } // Getters and setters for each table attribute

        public int? CategoryId { get; set; } // Need to fix this to be category ID, not category
        public Category? Category { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a title.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter a valid year.")]
        [Range(1880, 2024)]
        public int Year { get; set; }
        
        public string? Director { get; set; }
        
        public string? Rating { get; set; }
        [Required(ErrorMessage = "Sorry, you need to enter if the movie was edited.")]
        public bool Edited { get; set; }
        public string? LentTo { get; set; }
        [Required(ErrorMessage = "Sorry, you need to designate if the movie was copied to plex.")]
        public bool CopiedToPlex { get; set; }
        [MaxLength(25)] // Client Side entry validation
        [StringLength(25)] // Server side entry validation
        public string? Notes { get; set; } // ? parameter allows the field to be null. though a string attribute already has the option to be null
    }
}
