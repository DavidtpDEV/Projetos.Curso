
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required (ErrorMessage ="Campo Obrigatório")]
        [DisplayName("Título")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [DisplayName("Ano Lançamento")]
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }
}
