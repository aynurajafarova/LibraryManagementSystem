using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    class Order
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName ="date")]
        public DateTime OrderDate { get; set; }

        [Required]
        [Column(TypeName = "date")]
        public DateTime ReturnDate { get; set; }

        [Column(TypeName = "money")]
        public decimal Cost { get; set; }

        [Required]
        public bool Returned { get; set; }

        [Required]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [Required]
        public int MemberId { get; set; }
        public Member Member { get; set; }

    }
}
