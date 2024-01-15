using System.ComponentModel.DataAnnotations;
namespace GameLibrary
{
    public class Game
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Studio { get; set; }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string GameMode { get; set; }
        public int NumberOfSales { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public decimal? Rating { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public Game(string title, string studio, string genre, DateTime releaseDate, string gameMode, int numberOfSales, string description = null, string platform = null, decimal? rating = null)
        {
            Title = title;
            Studio = studio;
            Genre = genre;
            ReleaseDate = releaseDate;
            GameMode = gameMode;
            NumberOfSales = numberOfSales;
            Description = description;
            Platform = platform;
            Rating = rating;
        }
    }
}