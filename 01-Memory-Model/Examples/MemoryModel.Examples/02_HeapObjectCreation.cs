namespace MemoryModel.Examples;

    internal class HeapObjectCreation
    {
        // static void Main()
        // {
        //     Console.WriteLine("Main started");
        //
        //     CreatePerson();
        //
        //     Console.WriteLine("Main ended");
        // }

        static void CreatePerson()
        {
            Console.WriteLine("CreatePerson started");

            Person p = new Person();
            p.Name = "Ahmed";

            Console.WriteLine("CreatePerson ended");
        }
    }

    internal class Person
    {
        public string Name;
    }
