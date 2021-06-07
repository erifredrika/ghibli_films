using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ghibli.Models
{
    public class FilmInfo
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string OriginalTitle { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public int ReleaseDate { get; set; }
        public int RunningTime { get; set; }
        public int RTScore { get; set; }
    }
}
