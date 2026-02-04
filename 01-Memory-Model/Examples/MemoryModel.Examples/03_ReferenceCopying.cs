namespace MemoryModel.Examples;

internal class ReferenceCopying
{
    // static void Main()
    // {
    //     Person person = new Person();  
    //     person.Name = "Ahmed";
    //     Console.WriteLine("Before method call :"+person.Name);
    //     ChangeName(person);
    //     Console.WriteLine("After method call :"+person.Name);
    // }

    private static void ChangeName(Person person)
    {
        person.Name = "Ali";
    }
}