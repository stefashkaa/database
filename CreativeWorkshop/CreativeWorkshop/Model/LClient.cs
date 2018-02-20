namespace CreativeWorkshop.Model
{
    public class LClient
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }

        public LClient(string n, string a, long m, string e)
        {
            Name = n;
            Address = a;
            Mobile = m;
            Email = e;
        }
    }
}
