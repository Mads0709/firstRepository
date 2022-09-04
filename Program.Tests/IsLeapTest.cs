namespace IsLeapYear.Tests;


public class IsLeapYearTest
{
    [Fact]
    public void Test1()
    {

        //Arrange
        var year = new LeapYear();

        //Act
        var result = year.IsLeapYear(9);

        //Assert
        result.Should().Be(false);
    }
}