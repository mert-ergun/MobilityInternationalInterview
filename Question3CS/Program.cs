using System.Runtime.InteropServices;

class Program
{
    // Import the C++ function from the DLL
    [DllImport("Question3DLL.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern int Multiply(int a, int b);

    static void Main(string[] args)
    {
        // Input integers
        Console.WriteLine("Enter the first integer:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second integer:");
        int num2 = int.Parse(Console.ReadLine());

        // Call the C++ function
        int result = Multiply(num1, num2);

        // Display the result
        Console.WriteLine($"The result of multiplying {num1} and {num2} is: {result}");
    }
}
