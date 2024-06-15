namespace DiamondTest;

public class UnitTest1
{
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
}