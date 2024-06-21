
using KataDiamond;

for (char c = 'A'; c <= 'Z'; c++)
{
    Console.WriteLine(Diamond.Print(c));
    Thread.Sleep(5000);
    Console.Clear();
}