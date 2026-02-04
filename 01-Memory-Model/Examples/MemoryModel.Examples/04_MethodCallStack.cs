namespace MemoryModel.Examples;

internal class MethodCallStack
{
    static void Main()
    {
        Console.WriteLine("Main started");
        Person person = new Person();
        person.Name = "Ahmed";
        MethodA(person);
        Console.WriteLine("Main ended");
    }

    private static void MethodA(Person person)
    {
        Console.WriteLine("MethodA started");
        MethodB(person);
        Console.WriteLine("MethodA ended");

    }

    private static void MethodB(Person person)
    {
        Console.WriteLine("MethodB started");
        person.Name = "Ali";
        Console.WriteLine("MethodB ended");
    }
}