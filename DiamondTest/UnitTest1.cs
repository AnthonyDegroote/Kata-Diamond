namespace DiamondTest;

public class UnitTest1
{
    [Theory(DisplayName = "TestLineMiddleIndexOne")]
    // Arrange
    [InlineData('B', " A")]
    [InlineData('C', " B B")]
    [InlineData('D', " C   C")]
    [InlineData('E', " D     D")]
    [InlineData('F', " E       E")]
    [InlineData('G', " F         F")]
    public void TestLineMiddleIndexOne(char c, string exceptedLineMax)
    {
        // Act
        string actual = Diamond.Print(c);

        // Assert
        var lines = actual.Split(Environment.NewLine)
            .Where(line => !string.IsNullOrEmpty(line))
            .ToArray();
        Assert.Equal(exceptedLineMax, lines[(lines.Length/2)-1]);
    }

    [Theory(DisplayName = "TestLineMiddleIndexTwo")]
    // Arrange
    [InlineData('E', 2,   "  C     C")]       // EDCBABCDE
    [InlineData('F', 2,  "  D       D")]     // FEDCBABCDEF
    [InlineData('G', 2, "  E         E")]   // GFEDCBABCDEFG
    public void TestLineMiddleIndexTwo(char c, uint indexOfMiddle, string exceptedLineMax)
    {
        // Act
        string actual = Diamond.Print(c);

        // Assert
        var lines = actual.Split(Environment.NewLine)
            .Where(line => !string.IsNullOrEmpty(line))
            .ToArray();
        Assert.Equal(exceptedLineMax, lines[(lines.Length / 2) - indexOfMiddle]);
    }

    [Theory(DisplayName = "TestLineCount")]
    // Arrange
    [InlineData('A', 1)]
    [InlineData('B', 3)]
    [InlineData('C', 5)]
    [InlineData('D', 7)]
    [InlineData('E', 9)]
    [InlineData('F', 11)]
    [InlineData('G', 13)]
    public void TestLineCount(char c, int exceptedLineCount)
    {
        // Act
        string actual = Diamond.Print(c);
        // Assert
        var lines = actual.Split(Environment.NewLine)
            .Where(line => !string.IsNullOrEmpty(line))
            .ToArray();
        Assert.Equal(exceptedLineCount, lines.Length);
    }

    [Theory(DisplayName = "TestLineMax")]
    // Arrange
    [InlineData('A', "A")]
    [InlineData('B', "B B")]
    [InlineData('C', "C   C")]
    [InlineData('D', "D     D")]
    [InlineData('E', "E       E")]
    [InlineData('F', "F         F")]
    [InlineData('G', "G           G")]
    public void TestLineMax(char c, string exceptedLineMax)
    {
        // Act
        string actual = Diamond.Print(c);

        // Assert
        var lines = actual
            .Split(Environment.NewLine)
            .Select(line => line.Trim())
            .ToArray();
        Assert.Equal(exceptedLineMax, lines.MaxBy(line => line.Length));
    }

    [Fact(DisplayName = "TestB")]
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

    [Fact(DisplayName = "TestC")]
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

    [Fact(DisplayName = "TestD")]
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