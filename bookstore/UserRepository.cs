public static class UserRepository
{
    public static User Find(string username, string password)
    {
        var users = new List<User>()
        {
            new User() { Id = 1, Username = "admin", Password = "admin0439", Role = "admin" },
            new User() { Id = 2, Username = "client", Password = "client1387", Role = "client" }
        };
        return users.FirstOrDefault(user => user.Username.ToLower() == username.ToLower() && user.Password == password);
    }
}