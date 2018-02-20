namespace CreativeWorkshop.Model
{
    public class ServiceType
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public ServiceType(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
