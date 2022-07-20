using System.ComponentModel.DataAnnotations;

namespace MovieAPI.Models
{
    public class Movie
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength =3)]
        public string Title { get; set; } = String.Empty;
        [DataType(DataType.Date)]
        public DateTime dateTime { get; set; }
    }
}
