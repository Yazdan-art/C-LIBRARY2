//Console.WriteLine("Hello, World!");
using ClassLibrary1;

class Program
{
    static void Main(string[] args)
    {
        int row = 0;
        do
        {
            if (row == 0 || row >= 25)
            {
                ResetConsle();
            }
            string? input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            Console.WriteLine($"input:{input}");
            Console.WriteLine("Begins with uppercase?" + $"{(input.StartWithUpper() ? "Yes" : "No")}");
            Console.WriteLine();
            row += 4;
        } while (true);
        return;


       void ResetConsle()
        {
            if (row > 0) { Console.WriteLine("Pers any key to continue..."); 
            Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine($"{Environment.NewLine}Perss<Enter>only to exit ,otherwise, enter a string and press <Enter>:{Environment.NewLine}");
            row = 3;

        }
    }
}
