namespace CreativeWorkshop.Model
{
    public class Service
    {
        public int PurchaseId { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public int EmployeeId { get; set; }

        public Service(int purchaseId, string name, int count)
        {
            this.PurchaseId = purchaseId;
            this.Name = name;
            this.Count = count;
        }

        public Service(int purchaseId, string name, int count, int employeeId) : this(purchaseId, name, count)
        {
            this.EmployeeId = employeeId;
        }
    }
}
