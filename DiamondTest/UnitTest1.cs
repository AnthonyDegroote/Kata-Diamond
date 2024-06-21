namespace DiamondTest;

public class UnitTest1
{
    [Theory(DisplayName = "TestLineMiddleIndex")]
    // Arrange
    // BAB
    [InlineData('B', 1, " A")]
    // CBABC
    [InlineData('C', 2, "  A")]
    [InlineData('C', 1, " B B")]
    // DCBACBD
    [InlineData('D', 3, "   A")]
    [InlineData('D', 2, "  B B")]
    [InlineData('D', 1, " C   C")]
    // EDCBABCDE
    [InlineData('E', 4, "    A")]
    [InlineData('E', 3, "   B B")]
    [InlineData('E', 2, "  C   C")]
    [InlineData('E', 1, " D     D")]
    // FEDCBABCDEF
    [InlineData('F', 5, "     A")]
    [InlineData('F', 4, "    B B")]
    [InlineData('F', 3, "   C   C")]
    [InlineData('F', 2, "  D     D")]
    [InlineData('F', 1, " E       E")]
    // GFEDCBABCDEFG
    [InlineData('G', 2, "  E       E")]
    [InlineData('G', 1, " F         F")]
    public void TestLineMiddleIndex(char c, uint indexOfMiddle, string exceptedLineMax)
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