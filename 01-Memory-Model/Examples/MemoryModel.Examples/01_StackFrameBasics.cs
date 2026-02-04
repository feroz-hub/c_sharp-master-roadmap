namespace MemoryModel.Examples;
internal class StackFrameBasics
{
    // static void Main()
    // {
    //     Console.WriteLine("Main started");
    //     MethodA();
    //     Console.WriteLine("Main ended");
    // }

    static void MethodA()
    {
        Console.WriteLine("MethodA started");
        int x = 10;
        MethodB();
        Console.WriteLine("MethodA ended");
    }
    static void MethodB()
    {
        Console.WriteLine("MethodB started");
        int y = 20;
        Console.WriteLine("MethodB ended");
    }
}