namespace Diploma
{
    public class Employee
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Position { get; set; }
        public long Mobile { get; set; }

        public Employee(string s, string n, string p, string pos, long mobile)
        {
            Surname = s;
            Name = n;
            Patronymic = p;
            Position = pos;
            Mobile = mobile;
        }
    }
}
