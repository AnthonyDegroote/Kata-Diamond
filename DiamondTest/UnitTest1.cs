namespace DiamondTest;

public class UnitTest1
{
    [Theory]
    // Arrange
    [InlineData('A', "A")]
    [InlineData('E', "E       E")]
    public void TestLineMax(char c, string exceptedLineMax)
    {
        // Act
        string actual = Diamond.Print(c);

        // Assert
        var lines = actual.Split("\r\n");
        Assert.Equal(exceptedLineMax, lines.MaxBy(line => line.Length));
    }

    [Fact]
    public void TestB()
    {
        // Arrange
        string expected =
            """
             A
            B B
             A
            """;

        // Act
        string actual = Diamond.Print('B');

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestC()
    {
        // Arrange
        string expected =
            """
              A
             B B
            C   C
             B B
              A
            """;

        // Act
        string actual = Diamond.Print('C');

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestD()
    {
        // Arrange
        string expected =
            """
               A
              B B
             C   C
            D     D
             C   C
              B B
               A
            """;

        // Act
        string actual = Diamond.Print('D');

        // Assert
        Assert.Equal(expected, actual);
    }
}