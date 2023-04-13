using Azure.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entites
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [StringLength(10)]
        public string Name { get; set; }
        public string Date { get; set; }
        public int Cost { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
        //one to one relation with item
        //virtual for lazy loading from database
        public virtual Item Item { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
