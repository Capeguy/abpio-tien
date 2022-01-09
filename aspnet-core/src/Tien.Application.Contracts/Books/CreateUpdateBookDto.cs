using System.ComponentModel.DataAnnotations;

namespace Tien.Books
{
    public class CreateUpdateBookDto
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Isbn { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public string Price { get; set; }
    }
}
