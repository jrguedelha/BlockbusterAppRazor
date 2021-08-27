using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlockbusterAppRazor.Models
{
    public class MovieModel
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string ReleaseDate { get; set; }
        public bool IsActive { get; set; }
        public string Genre { get; set; }
    }
}
