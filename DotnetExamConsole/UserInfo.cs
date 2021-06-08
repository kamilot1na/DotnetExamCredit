namespace DotnetExamConsole
{
    public class UserInfo
    {
        public User User { get; set; }
        public bool IsConvicted { get; set; }
        public int CreditSum { get; set; }
        public Target Target{ get;set; }
        public Employment Employment { get; set; }
        public bool HaveOtherCredits { get; set; }
        public Zalog Zalog { get; set; }
    }
}