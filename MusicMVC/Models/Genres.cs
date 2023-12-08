using System.ComponentModel.DataAnnotations;

namespace MusicMVC.Models
{

    public class Genres
    {
        [Key]
        public int GenreID { get; set; }
        public string GenreType { get; set; }
    }
}
