namespace CreativeWorkshop.Model
{
    public class PClient
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Address { get; set; }
        public long Mobile { get; set; }
        public string Email { get; set; }

        public PClient(string s, string n, string p, string address, long mobile, string email)
        {
            Surname = s;
            Name = n;
            Patronymic = p;
            Address = address;
            Mobile = mobile;
            Email = email;
        }

        public string GetShortName()
        {
            return $"{Surname} {Name[0]}. {Patronymic[0]}.";
        }
    }

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
