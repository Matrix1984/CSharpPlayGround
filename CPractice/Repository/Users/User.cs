using CPractice.Repository.Deposits;


namespace CPractice.Repository.Users
{
    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DOb { get; set; }

        public string Description { get; set; }

        public List<Deposit> Deposits { get; set; }
    }
}
