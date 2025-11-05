class Program
{
    static void Main()
    {

        byte byteVar = 25;
        short shortVar = 1500;
        int intVar = 75;
        long longVar = 222222222222L;
        float floatVar = 5.67F;
        double doubleVar = 45.678;
        decimal decimalVar = 99999.9999M;
        char charVar = 'Z';
        bool boolVar = false;

        string intToString = intVar.ToString();
        double stringToDouble = Convert.ToDouble("6.28");

        Console.WriteLine("=== Data Types and Type Conversion ===");
        Console.WriteLine($"byteVar (byte): {byteVar}");
        Console.WriteLine($"shortVar (short): {shortVar}");
        Console.WriteLine($"intVar (int): {intVar}");
        Console.WriteLine($"longVar (long): {longVar}");
        Console.WriteLine($"floatVar (float): {floatVar}");
        Console.WriteLine($"doubleVar (double): {doubleVar}");
        Console.WriteLine($"decimalVar (decimal): {decimalVar}");
        Console.WriteLine($"charVar (char): {charVar}");
        Console.WriteLine($"boolVar (bool): {boolVar}");
        Console.WriteLine($"intToString (string): {intToString}");
        Console.WriteLine($"stringToDouble (double): {stringToDouble}");

    }
}
