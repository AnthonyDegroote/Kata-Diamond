
using KataDiamond;

for (char letter = 'A'; letter < 'Z'; letter++)
{
    Console.WriteLine(Diamond.Print(letter));
    Thread.Sleep(1000);
    Console.Clear();
}
for (char letter = 'Z'; letter >= 'A'; letter--)
{
    Console.WriteLine(Diamond.Print(letter));
    Thread.Sleep(1000);
    Console.Clear();
}