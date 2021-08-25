using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MVCMovie.Models
{
    public class Movie
    {
        public Movie()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }
        public string Email { get; set; }

        public string Language { get; set; }

        public Category MovieCategory { get; set; }
    }

    public enum LanguageType
    {
        Chinese,
        English,
        Japanese
    }

}
