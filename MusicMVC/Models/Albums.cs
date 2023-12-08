using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicMVC.Models
{
    [Table("tblAlbum")]
    public class Albums
    {
        [Key]
        public int AlbumID { get; set; }

        public String AlbumName { get; set; }

        public String DateReleased { get; set; }

        
        public int ArtistID { get; set; }

        
        public int GenreID { get; set; }

    }
}
