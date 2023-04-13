namespace DemoOrderApp.Models
{
    public class Order : Base
    {
        public string Date { get; set; }
        public int Cost { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }

    }
}
