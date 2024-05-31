using System;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

#nullable disable

namespace HellowWorld;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("\t\t\t\tHellow C#");
        for(int i = 0; i < 79; i++)
            Console.Write('=');
        Console.Write('\n');
        const string strType = "Type";
        const string strBytes = "Bytes(s) of memory";
        const string strMin = "Min";
        const string strMax = "Max";
        const int i64 = 30;
        Console.WriteLine($"{strType, 0}\t {strBytes, 0}\t\t    {strMin, 0}\t\t\t\t    {strMax, 0}");
        for(int i = 0; i < 79; i++)
            Console.Write('=');
        Console.WriteLine($"\n{"sbyte", 0}\t {sizeof(sbyte),-2}\t {sbyte.MinValue, i64}\t {sbyte.MaxValue , i64}");
        Console.WriteLine($"{"byte", 0}\t {sizeof(byte), -2}\t {byte.MinValue, i64}\t {byte.MaxValue, i64}");
        Console.WriteLine($"{"short", 0}\t {sizeof(short), -2}\t {short.MinValue, i64}\t {byte.MaxValue, i64}");
        Console.WriteLine($"{"ushort", 0}\t {sizeof(ushort), -2}\t {ushort.MinValue, i64}\t {ushort.MaxValue, i64}");
        Console.WriteLine($"{"int", 0}\t {sizeof(int), -2}\t {int.MinValue, i64}\t {int.MaxValue, i64}");
        Console.WriteLine($"{"uint", 0}\t {sizeof(uint), -2}\t {uint.MinValue, i64}\t {uint.MaxValue, i64}");
        Console.WriteLine($"{"long", 0}\t {sizeof(long), -2}\t {long.MinValue, i64}\t {long.MaxValue, i64}");
        Console.WriteLine($"{"ulong", 0}\t {sizeof(ulong), -2}\t {ulong.MinValue, i64}\t {ulong.MaxValue, i64}");
        Console.WriteLine($"{"float", 0}\t {sizeof(float), -2}\t {float.MinValue, i64}\t {float.MaxValue, i64}");
        Console.WriteLine($"{"double", 0}\t {sizeof(double), -2}\t {double.MinValue, i64}\t {double.MaxValue, i64}");
        Console.WriteLine($"{"decimal", 0}\t {sizeof(decimal), -2}\t {decimal.MinValue, i64}\t {decimal.MaxValue, i64}");
        for(int i = 0; i < 79; i++)
            Console.Write('=');
    }
}
