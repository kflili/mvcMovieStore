using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcMovieStore.Dtos
{
    public class MovieDto
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        public int GenreID { get; set; }

        public GenreDto Genre { get; set; }

        public DateTime DateAdded { get; set; }

        public DateTime ReleaseDate { get; set; }

        [Range(1, 20)]
        public int NumberInStock { get; set; }
    }
}