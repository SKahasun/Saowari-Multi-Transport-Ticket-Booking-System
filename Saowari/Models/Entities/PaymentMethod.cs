using System.ComponentModel.DataAnnotations;

namespace Saowari.Models.Entities
{
    public class PaymentMethod
    {
        public int PaymentMethodId { get; set; }
        [Required,StringLength(50)]
        public string PaymentMethodName { get; set; } =null!;
        public virtual ICollection<Payment> Payments { get; set; } = new List<Payment>();
    }
}
