
using KataDiamond;
const int sleepTime = 200;

do
{
    for (char letter = 'A'; letter < 'Z'; letter++)
    {
        Console.WriteLine(Diamond.Print(letter));
        Thread.Sleep(sleepTime);
        Console.Clear();
    }
    for (char letter = 'Z'; letter >= 'B'; letter--)
    {
        Console.WriteLine(Diamond.Print(letter));
        Thread.Sleep(sleepTime);
        Console.Clear();
    }
}
while (true);