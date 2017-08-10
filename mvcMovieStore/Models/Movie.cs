using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace mvcMovieStore.Models
{
    public class Movie
    {
        public int ID { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public int GenreID { get; set; }

        public DateTime DateAdded { get; set; }

        [Display(Name="Release Date")]
        [DisplayFormat(DataFormatString = "0:d MMM yyyy")]
        public DateTime ReleaseDate { get; set; }

        [Display(Name ="Number in Stock")]
        public int NumberInStock { get; set; }
    }
}