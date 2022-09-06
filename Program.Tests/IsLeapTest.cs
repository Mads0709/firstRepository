namespace Program.Tests;

public class IsLeapYearTest
{
    [Fact]
    public void Leap_Year_year1600()
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
    public void Leap_Year_year1700()
    {

        //Arrange
        int year = 1700;
        var leapYear = new LeapYear();

        //Act
        var result = leapYear.IsLeapYear(year);

        //Assert
        result.Should().Be(false);
    }
}