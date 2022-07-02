using Domain.Entities.Movies;

namespace Domain.Entities
{
    public class Movie
    {
        public string ImdbId { get; set; }
        public string Title { get; set; }
        public DateTime Released { get; set; }

        public string RunTime { get; set; }
        public string Genre { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string Language { get; set; }
        public string Country { get; set; }
        public string Awards { get; set; }
        public string Poster { get; set; }

        public List<Rating> Rating { get; set; }
        public string Metascore { get; set; }
        public string ImdbRating { get; set; }
        public string ImdbVotes { get; set; }
        public string Type { get; set; }
        public string Dvd { get; set; }
        public string BoxOffice { get; set; }
        public string Production { get; set; }
        public string WebSite { get; set; }
        public string Response { get; set; }


    }
}
