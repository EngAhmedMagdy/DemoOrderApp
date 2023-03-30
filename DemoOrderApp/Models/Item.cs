namespace DemoOrderApp.Models
{
    public class Item : Base
    {
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
