using System.Text;

namespace KataDiamond;

public static class Diamond
{
    public static string Print(char v)
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

        uint numberSpaceMiddle = NumberSpaceMiddle(printLetter);
        uint numberSpaceFirst = (uint)(v - printLetter);

        if (numberSpaceMiddle == 0)
        {
            return $"{PrintSpace(numberSpaceFirst)}{printLetter}";
        }
        return $"{PrintSpace(numberSpaceFirst)}{printLetter}{PrintSpace(numberSpaceMiddle)}{printLetter}";
    }

    private static uint NumberSpaceMiddle(char printLetter)
    {
        uint numberSpaceMiddle = 0;
        if (printLetter >= 'B')
        {
            numberSpaceMiddle = 1;
            for (char i = 'C'; i <= printLetter; i++)
            {
                numberSpaceMiddle += 2;
            }
        }

        return numberSpaceMiddle;
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