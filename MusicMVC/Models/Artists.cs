using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MusicMVC.Models
{
    [Table("tblArtists")]
    public class Artists
    {
        [Key]
        public int ArtistID { get; set; }

        public String ArtistName { get; set; }
    }
}
