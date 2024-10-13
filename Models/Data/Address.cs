using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderService.Models.Data
{
    [Table("Addresses")]
    public class Address
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Street { get; set; }

        [Required]
        public string? StreetNumber { get; set; }

        [Required]
        public string? City { get; set; }

        [Required]
        [MaxLength(5)]
        public string? ZipCode { get; set; }

        public int? UserId { get; set; }


        [ForeignKey("UserId")]
        public virtual User? User { get; set; }
    }

}
