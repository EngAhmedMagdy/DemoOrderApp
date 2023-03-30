namespace DemoOrderApp.Models
{
    public class Order : Base
    {
        public string Date { get; set; }
        public Customer customer { get; set; }
        public List<Item> Items { get; set; }
        public Order()
        {
        }
        public Order(int id, string date,Customer customer)
        {
            Id = id;
            this.customer = customer;
            this.Date = date;
        }

    }
}
