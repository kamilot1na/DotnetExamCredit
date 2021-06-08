namespace DotnetExamConsole
{
    public class Fio
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
    }
    public class User
    {
        public Fio Fio { get; set; }
        public int Age { get; set; }
        public Passport Passport { get; set; }
    }
}