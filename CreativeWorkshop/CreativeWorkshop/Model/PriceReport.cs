namespace CreativeWorkshop.Model
{
    public class PriceReport
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public long Summa { get; set; }

        public PriceReport(string name, int price, int count, long summa)
        {
            Name = name;
            Price = price;
            Count = count;
            Summa = summa;
        }
    }
}
