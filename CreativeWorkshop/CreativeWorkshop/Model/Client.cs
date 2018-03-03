namespace CreativeWorkshop.Model
{
    public interface Client
    {
        string Name { get; set; }
        string Address { get; set; }
        long Mobile { get; set; }
        string Email { get; set; }
    }

    public class PClient : Client
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

    public class LClient : Client
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
