using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagementSystem.Models
{
    class Book
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string Name { get; set; }

        [Required]
        [MaxLength(100)]

        public string Author { get; set; }

        [Required]
        [Column(TypeName ="money")]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        //public ICollection<Member> Members { get; set; }

    }
}
