
using System.Collections.Specialized;
using System.Security.Cryptography;
using static System.Convert;
namespace Chapter_3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number between 0 and 255: ");
        string? input = Console.ReadLine();
        Console.WriteLine("Enter anothe number between 0 and 255: ");
        string? inputSecond = Console.ReadLine();
        try{
            checked{
                byte number = byte.Parse(input);
                byte number2 = byte.Parse(inputSecond);
                Console.WriteLine($"{number / number2}");
                   }
        }catch(Exception ex)
        {
            Console.WriteLine($"{ex.GetType} syas {ex.Message}");
        
        }        
    }
}
