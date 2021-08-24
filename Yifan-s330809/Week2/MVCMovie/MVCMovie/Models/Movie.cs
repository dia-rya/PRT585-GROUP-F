using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCMovie.Models
{
    public class Movie
    {
        //public Movie()
        //{

        //}

        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }
        public string Email { get; set; }

    }
}
