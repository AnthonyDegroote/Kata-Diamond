using System.Text;

namespace KataDiamond;

public static class Diamond
{
    public static string Print(char letter)
    {
        char maxLetter = (char)(letter - 'A');

        StringBuilder stringBuilder = new();

        for (int i = 0; i < maxLetter; i++)
        {
            stringBuilder.AppendLine(NewMethod(letter, i));
        }

        for (int i = maxLetter; i >= 0; i--)
        {
            if (i == 0)
            {
                stringBuilder.Append(NewMethod(letter, i));
            }
            else
            {
                stringBuilder.AppendLine(NewMethod(letter, i));
            }
        }

        return stringBuilder.ToString();
    }

    private static string NewMethod(char letter, int i)
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