namespace MyApp.Tests;
using MyApp;

public class IsLeapYearTest
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

    [Fact]
    public void Devide_By_Four_True()
    {
        //Setup
        //Act
        var res = Program.IsLeapYear(4);
        //Assert
        Assert.True(res);

    }
}