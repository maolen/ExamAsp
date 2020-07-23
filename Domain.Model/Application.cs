namespace Domain.Model
{
    public class Application
    {
        public int Id { get; set; }
        public string Iin { get; set; }
        public int Score { get; set; }
        public Profile FirstProfile { get; set; }
        public Profile SecondProfile { get; set; }
        public College College { get; set; }
    }
}
