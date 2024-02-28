namespace Builder
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public User() { }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Phone: {Phone}, Address: {Address}";
        }
    }
}