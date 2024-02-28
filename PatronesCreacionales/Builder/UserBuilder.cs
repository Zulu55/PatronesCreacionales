namespace Builder
{
    public class UserBuilder : IUserBuilder
    {
        private User _user = new User();

        public IUserBuilder SetName(string name)
        {
            _user.Name = name;
            return this;
        }

        public IUserBuilder SetEmail(string email)
        {
            _user.Email = email;
            return this;
        }

        public IUserBuilder SetPhone(string phone)
        {
            _user.Phone = phone;
            return this;
        }

        public IUserBuilder SetAddress(string address)
        {
            _user.Address = address;
            return this;
        }

        public User Build()
        {
            return _user;
        }
    }
}