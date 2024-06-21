﻿
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
            NewMethod(v, stringBuilder, i);
        }

        PrintMiddleLine(v, stringBuilder);

        for (int i = (v - 'A'); i > 0; i--)
        {
            NewMethod(v, stringBuilder, i);
        }

        return stringBuilder.ToString();
    }

    private static void NewMethod(char v, StringBuilder stringBuilder, int i)
    {
        uint numberSpace;
        if (v == 'E')
        {
            numberSpace = 5;
        }
        else if (v == 'F')
        {
            numberSpace = 7;
        }
        else if (v == 'G')
        {
            numberSpace = 9;
        }
        else
        {
            numberSpace = 0;
        }

        stringBuilder.AppendLine($"{PrintSpace(1)}{(char)('A' + i)}{PrintSpace(numberSpace)}{(char)('A' + i)}");
    }

    private static string PrintSpace(uint numberSpace)
    {
        StringBuilder stringBuilder = new();
        for (uint j = 0; j < numberSpace; j++)
        {
            stringBuilder.Append(" ");
        }
        string space = stringBuilder.ToString();
        return space;
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