namespace LegacyApp.Tests;

public class UserServiceTests
{
    [Fact]
    public void AddUser_ReturnsFalseWhenFirstNameisEmpty()
    {
        var userService = new UserService();
        
        var result = userService.AddUser(null ,"Kowalski",
            "kowal@gmail.com",DateTime.Parse("2000-01-01"),1);
        
        Assert.False(result);

    }
}