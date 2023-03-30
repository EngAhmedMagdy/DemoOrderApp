namespace DemoOrderApp.Models
{
    public class Customer : Base
    {
        public string  Address { get; set; }
        public string PhoneNumber { get; set; }
        public Customer(int id)
        {
            Id = id;
        }
        public Customer(int id, string name, string address, string phoneNumber)
        {
            Id = id;
            Name = name;
            Address = address;
            PhoneNumber = phoneNumber;
        }
    }
}
