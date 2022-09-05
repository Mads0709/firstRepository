namespace Program.Tests;

public class IsLeapYearTest
{
    [Fact]
    public void Leap_Year_Test()
    {

        //Arrange
        int year = 1600;
        var LeapYear = new LeapYear();

        //Act
        var result = LeapYear.IsLeapYear(year);

        //Assert
        result.Should().Be(false);
    }
}