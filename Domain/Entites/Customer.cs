using System.ComponentModel.DataAnnotations;

namespace Domain.Entites
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string  Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Role { get; set; }
    }
}
