using System.ComponentModel.DataAnnotations;


namespace BlockbusterAppRazor.Models
{
    public class GenreModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public bool IsActive { get; set; }
    }
}
