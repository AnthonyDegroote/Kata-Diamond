
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

        PrintMiddleLine(v, stringBuilder);

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