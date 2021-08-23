using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MvcMovie.Models
{
    public class Movies
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [DataType(DataType.Date)]

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Director { get; set; }

        public string ContactEmail { get; set; }

        public string Genre { get; set; }

        public decimal Price { get; set; }
    }
}
