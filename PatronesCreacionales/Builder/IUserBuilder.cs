namespace Builder
{
    public interface IUserBuilder
    {
        IUserBuilder SetName(string name);

        IUserBuilder SetEmail(string email);

        IUserBuilder SetPhone(string phone);

        IUserBuilder SetAddress(string address);

        User Build();
    }
}