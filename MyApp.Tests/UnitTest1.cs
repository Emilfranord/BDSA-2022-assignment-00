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
    public void Divide_By_Four_True()
    {
        //Setup
        //Act
        var res = Program.IsLeapYear(4);
        //Assert
        Assert.True(res);

    }

    [Fact]
    public void Hundreds_Handled()
    {
        //Setup
        //Act
        //Assert
        Assert.False(Program.IsLeapYear(100));
        Assert.False(Program.IsLeapYear(200));
        Assert.False(Program.IsLeapYear(300));

        Assert.True(Program.IsLeapYear(400));
    }

    [Fact]
    public void Hundreds_Large_Years()
    {
        //Setup
        //Act
        //Assert
        Assert.False(Program.IsLeapYear(1700));
        Assert.False(Program.IsLeapYear(1800));
        Assert.False(Program.IsLeapYear(1900));

        Assert.True(Program.IsLeapYear(1600));
        Assert.True(Program.IsLeapYear(2000));
    } 

    [Fact]
    public void Bool_Converter_Single_Args(){
        Assert.Equal("yay", Program.BoolConverter(true));
        Assert.Equal("nay", Program.BoolConverter(false));
    }
}