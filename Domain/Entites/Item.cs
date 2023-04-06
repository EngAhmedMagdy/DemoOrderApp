namespace Domain.Entites
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public Item(int id,int price,string name)
        {
            this.Id = id;
            this.Price = price;
            this.Name = name;
        }
    }
}
