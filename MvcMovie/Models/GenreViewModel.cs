using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcMovie.Models
{
    public class GenreViewModel
    {
        public Movie Movie { get; set; }
        public SelectList Genres { get; set; }
        public string MovieGenre { get; set; }
    }
}
