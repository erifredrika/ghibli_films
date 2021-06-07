using System.Collections.Generic;

namespace ghibli.Models
{
    public class Film
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Original_Title { get; set; }
        public string Description { get; set; }
        public string Director { get; set; }
        public string Producer { get; set; }
        public string Release_Date { get; set; }
        public string Running_Time { get; set; }
        public string RT_Score { get; set; }
    }

    public static class FilmExtensions
    {
        public static FilmInfo ToFilmInfo(this Film film)
        {
            return new FilmInfo
            {
                Id = film.Id,
                Description = film.Description,
                Director = film.Director,
                OriginalTitle = film.Original_Title,
                Producer = film.Producer,
                ReleaseDate = int.Parse(film.Release_Date),
                RTScore = int.Parse(film.RT_Score),
                RunningTime = int.Parse(film.Running_Time),
                Title = film.Title
            };
        }
    }
}
