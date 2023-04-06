namespace Domain.Entites
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
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
