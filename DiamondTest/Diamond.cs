
using System.Text;

namespace DiamondTest;

internal static class Diamond
{

    internal static string Print(char v)
    {
        StringBuilder stringBuilder = new();

        if (v == 'D')
        {
            stringBuilder.AppendLine("   A   ".TrimEnd());
            stringBuilder.AppendLine("  B B  ".TrimEnd());
            stringBuilder.AppendLine(" C   C ".TrimEnd());
            stringBuilder.AppendLine("D     D".TrimEnd());
            stringBuilder.AppendLine(" C   C ".TrimEnd());
            stringBuilder.AppendLine("  B B  ".TrimEnd());
            stringBuilder.Append("   A   ".TrimEnd());

            return stringBuilder.ToString();
        }


        stringBuilder.AppendLine("  A  ".TrimEnd()); 
        stringBuilder.AppendLine(" B B ".TrimEnd());
        stringBuilder.AppendLine("C   C".TrimEnd()); 
        stringBuilder.AppendLine(" B B ".TrimEnd());
        stringBuilder.Append("  A  ".TrimEnd());

        return stringBuilder.ToString();
    }
}