using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saowari.Models.Entities
{
    [Table("SeatPricing")]
    public class SeatPricing
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PricingID { get; set; }

        [Required]
        [ForeignKey(nameof(SeatClass))]
        public int SeatClassId { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        [Range(0, 99999999.99)]
        public decimal Price { get; set; }

        [Required]
        public DateTime LastUpdate { get; set; }

        public virtual SeatClass? SeatClass { get; set; }
    }
}
