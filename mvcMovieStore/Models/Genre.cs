using System.ComponentModel.DataAnnotations;

namespace mvcMovieStore.Models
{
    public class Genre
    {
        public int ID { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}