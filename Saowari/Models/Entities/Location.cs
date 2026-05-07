using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Saowari.Models.Entities
{
    [Table("Location")]
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocationID { get; set; }

        [Required]
        [MaxLength(100)]
        public string LocationName { get; set; } = null!;


        [Column(TypeName = "decimal(9,6)")]
        public decimal LocationCode { get; set; }

        [Column(TypeName = "decimal(9,6)")]
        public decimal Latitude { get; set; } 

        [MaxLength(60)]
        public string Longitude { get; set; } = null!;

        [MaxLength(100)]
        public string? District { get; set; }

        public bool IsActive { get; set; } = true;

        public virtual ICollection<Route> DepartureRoutes { get; set; } = new List<Route>();
        public virtual ICollection<Route> ArrivalRoutes { get; set; } = new List<Route>();

    }
}
