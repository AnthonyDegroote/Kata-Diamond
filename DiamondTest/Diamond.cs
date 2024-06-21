
using System.Text;

namespace DiamondTest;

internal static class Diamond
{
    internal static string Print(char v)
    {
        StringBuilder stringBuilder = new();

        if (v == 'B')
        {
            stringBuilder.AppendLine(" A ".TrimEnd());
            PrintMiddleLine(v, stringBuilder);
            stringBuilder.Append(" A ".TrimEnd());

            return stringBuilder.ToString();
        }

        if (v == 'C')
        {
            stringBuilder.AppendLine("  A  ".TrimEnd());
            stringBuilder.AppendLine(" B B ".TrimEnd());
            PrintMiddleLine(v, stringBuilder);
            stringBuilder.AppendLine(" B B ".TrimEnd());
            stringBuilder.Append("  A  ".TrimEnd());

            return stringBuilder.ToString();
        }

        if (v == 'D')
        {
            stringBuilder.AppendLine("   A   ".TrimEnd());
            stringBuilder.AppendLine("  B B  ".TrimEnd());
            stringBuilder.AppendLine(" C   C ".TrimEnd());
            PrintMiddleLine(v, stringBuilder);
            stringBuilder.AppendLine(" C   C ".TrimEnd());
            stringBuilder.AppendLine("  B B  ".TrimEnd());
            stringBuilder.Append("   A   ".TrimEnd());

            return stringBuilder.ToString();
        }

        for (int i = 0; i < (v - 'A'); i++)
        {
            stringBuilder.AppendLine(NewMethod(v, i));
        }

        PrintMiddleLine(v, stringBuilder);

        for (int i = (v - 'A'); i > 0; i--)
        {
            stringBuilder.AppendLine(NewMethod(v, i));
        }

        return stringBuilder.ToString();
    }

    private static string NewMethod(char v, int i)
    {
        char printLetter = (char)('A' + i);

        uint numberSpaceMiddle = 0;
        uint numberSpaceFirst = 1;

        if (v == 'E')
        {
            numberSpaceMiddle = 5;
            if (printLetter == 'C')
            {
                numberSpaceMiddle = 3;
                numberSpaceFirst = 2;
            }
            else if (printLetter == 'B')
            {
                numberSpaceMiddle = 1;
                numberSpaceFirst = 3;
            }
            else if (printLetter == 'A')
            {
                numberSpaceMiddle = 0;
                numberSpaceFirst = 4;
            }
        }
        else if (v == 'F')
        {
            numberSpaceMiddle = 7;
            if (printLetter == 'D')
            {
                numberSpaceMiddle = 5;
                numberSpaceFirst = 2;
            }
            else if (printLetter == 'C')
            {
                numberSpaceMiddle = 3;
                numberSpaceFirst = 3;
            }
            else if (printLetter == 'B')
            {
                numberSpaceMiddle = 1;
                numberSpaceFirst = 4;
            }
            else if (printLetter == 'A')
            {
                numberSpaceMiddle = 0;
                numberSpaceFirst = 5;
            }
        }
        else if (v == 'G')
        {
            numberSpaceMiddle = 9;
            if (printLetter == 'E')
            {
                numberSpaceMiddle = 7;
                numberSpaceFirst = 2;
            }
        }
        else
        {
            numberSpaceMiddle = 0;
            numberSpaceFirst = 0;
        }

        if (numberSpaceMiddle == 0)
        {
            return $"{PrintSpace(numberSpaceFirst)}{printLetter}";
        }
        return $"{PrintSpace(numberSpaceFirst)}{printLetter}{PrintSpace(numberSpaceMiddle)}{printLetter}";
    }

    private static string PrintSpace(uint numberSpace)
    {
        const char space = ' ';
        StringBuilder stringBuilder = new();
        for (uint j = 0; j < numberSpace; j++)
        {
            stringBuilder.Append(space);
        }
        return stringBuilder.ToString();
    }

    private static void PrintMiddleLine(char v, StringBuilder stringBuilder)
    {
        if (v == 'A')
        {
            stringBuilder.Append(v);
        }
        else
        {
            stringBuilder.Append(v);
            for (int i = 1; i < ((v - 'A') * 2); i++)
            {
                stringBuilder.Append(' ');
            }
            stringBuilder.Append(v);
        }
        stringBuilder.AppendLine();
    }
}