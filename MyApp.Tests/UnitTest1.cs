namespace MyApp.Tests;
using MyApp;

public class UnitTest1
{
    [Fact]
    public void Non_leap_Return_False()
    {
        //Setup

        //Act
        var res = Program.IsLeapYear(3);

        //Assert
        Assert.False(res);

    }
}