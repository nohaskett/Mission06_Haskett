using System.ComponentModel.DataAnnotations;

namespace Mission06_Haskett.Models
{
    public class MovieSurvey
    {
        [Key]
        [Required]
        public int MovieEntryID { get ; set; }
        [Required]
        public string Category { get; set;}
        public string? Category2 { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? LentTo { get; set; }
        [MaxLength(25)]
        [StringLength(25)]
        public string? Notes { get; set; }
    }
}
