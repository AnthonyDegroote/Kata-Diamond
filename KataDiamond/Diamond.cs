﻿using System.Text;

namespace KataDiamond;

public static class Diamond
{
    public static string Print(char letter)
    {
        ushort maxLetter = (char)(letter - 'A');

        StringBuilder stringBuilder = new();

        for (int i = 0; i < maxLetter; i++)
        {
            stringBuilder.AppendLine(PrintLine(letter, i));
        }

        for (int i = maxLetter; i > 0; i--)
        {
            stringBuilder.AppendLine(PrintLine(letter, i));
        }

        stringBuilder.Append(PrintLine(letter, 0));

        return stringBuilder.ToString();
    }

    private static string PrintLine(char letter, int i)
    {
        char printLetter = (char)('A' + i);

        ushort numberSpaceMiddle = NumberSpaceMiddle(printLetter);
        ushort numberSpaceFirst = (ushort)(letter - printLetter);

        if (numberSpaceMiddle == 0)
        {
            return $"{PrintSpace(numberSpaceFirst)}{printLetter}";
        }
        return $"{PrintSpace(numberSpaceFirst)}{printLetter}{PrintSpace(numberSpaceMiddle)}{printLetter}";
    }

    private static ushort NumberSpaceMiddle(char printLetter)
    {
        ushort numberSpaceMiddle = 0;
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
}