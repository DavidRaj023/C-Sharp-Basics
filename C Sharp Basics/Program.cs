

using Basics.topic;
using Basics.util;
using Basics.collections;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            /* //Object
             Person person = new Person();
             person.firstName = "David";
             person.lastName = "Raj";
             person.dob = new DateOnly(1998, 02, 23);
             person.age = Util.getAge(person.dob);
             person.intro();

             //String demo

             StringDemo.demoString();

             //Enum example
             var employeeCurrentStatus = 0;

             Console.WriteLine((EmployeeStatus)employeeCurrentStatus);

             Console.WriteLine((int)EmployeeStatus.active);

             //Reference and Value type
             ReferenceAndValueTypes.getDemo();

             //Control Flow
             ControlFlow.checkEmployeeStatus(0);

             //Loops
             Iteration.findRandomNumber();

             //Array
             int[] numbers = new int[] { 0, 4, 5, 6 ,2, 63, 2, 12};
             ArrayDemo.getDemo(numbers);*/

            //List
            /*var numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            numbers.Add(99);
            numbers.IndexOf(1);
            numbers.LastIndexOf(2);
            numbers.Remove(2);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }*/

            /*//DateTime
            var dateTime = new DateTime(2022, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Day);
            var tomorrow = now.AddDays(1);

            //Date Format
            var format = now.ToString("yyyy-MM-dd");
            Console.WriteLine(format);*/

            //File 
            /*var Path = @"C:\Users\David Raj E\Desktop\Notes.txt";
            Console.WriteLine(File.ReadAllText(Path));
            var fileinfo = new FileInfo(Path);
            Console.WriteLine(fileinfo);*/

            /*//Directory
            var Path = @"C:\Users\David Raj E\Desktop\";
            var files = Directory.GetFiles(Path, "*.*", SearchOption.AllDirectories);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }

            //to get directories only
            var directory = Directory.GetDirectories(Path, "*.*", SearchOption.AllDirectories);
            foreach(string file in directory)
            {
                Console.WriteLine(file); 
            }*/

            //Collection
            //----------------

            //ArrayList
            //ArrayListDemo.getArrayListDemo();

            //HashTable
            //HashTableDemo.getHashTableDemo();

            //Stack
            StackDemo.getStackDemo();

        }

    }
}