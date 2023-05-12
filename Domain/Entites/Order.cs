using Azure.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string Date { get; set; }
        public int Cost { get; set; }
        [ForeignKey("CartItem")]
        public int CartItemId { get; set; }
        public virtual CartItem CartItem { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        public virtual Customer? Customer { get; set; }
    }
}
