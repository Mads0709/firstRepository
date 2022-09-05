namespace Program.Tests;

public class IsLeapYearTest
{
    [Fact]
    public void Leap_Year_Test()
    {

        //Arrange
        int year = 1600;
        var leapYear = new LeapYear();

        //Act
        var result = leapYear.IsLeapYear(year);

        //Assert
        result.Should().Be(true);
    }

    [Fact]
    public void Write(){
        var program = new Program();

    }
}