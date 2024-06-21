using System.Text;

namespace KataDiamond;

public static class Diamond
{
    public static string Print(char v)
    {
        StringBuilder stringBuilder = new();

        for (int i = 0; i < (v - 'A'); i++)
        {
            stringBuilder.AppendLine(NewMethod(v, i));
        }

        for (int i = (v - 'A'); i >= 0; i--)
        {
            if (i == 0)
            {
                stringBuilder.Append(NewMethod(v, i));
            }
            else
            {
                stringBuilder.AppendLine(NewMethod(v, i));
            }
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
}