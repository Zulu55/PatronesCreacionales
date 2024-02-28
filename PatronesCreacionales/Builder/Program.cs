using Builder;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = new UserBuilder();
        User user = builder.SetName("John Doe")
                           .SetEmail("john.doe@example.com")
                           .SetPhone("1234567890")
                           .Build();

        Console.WriteLine(user.ToString());
    }
}