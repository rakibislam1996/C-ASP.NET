using System;

namespace ValueTuple
{
    internal class Program
    {
        public static (int, string, double) Fun((int, string, double) person)
        {
            if(person.Item2==null)
            {
                return (101, "Rakib", 25.5);
            }
            return person;
        }
        static (int Id, string FirstName, string LastName) GetPerson()
        {
            return (Id: 1, FirstName: "Bill", LastName: "Gates");
        }
        static void Main(string[] args)
        {
            ValueTuple<int, string, double> person = (1, "Steve", 25.3);
            Console.WriteLine(person.Item1+" "+person.Item2+" "+person.Item3);
            person.Item1 = 101;
            person.Item2 = "Rakib";
            person.Item3 = 25.5;

            var person2 = (3, "Araft", 45.1);

            (int, string, int) person3 = (2, "James", 27);

            (int Id, string Name, int Age) person4 = (1, "Bill", 25);
            Console.WriteLine(person4.Id+" "+person4.Name+" "+person4.Age);

            var person5 = (Id: 1, FirstName: "Bill", LastName: "Gates");

            string Name = "Sakib";
            int Id = 7, Age = 35;
            var person6 = (Id: Id, Name: Name, LastName: Age);

            var person7 = GetPerson();
            (int PersonId, string FName, string LName) = GetPerson();
            Console.WriteLine(PersonId +" "+FName+" "+LName);
            
            (var id, var name, _) = GetPerson();

            var numbers = (1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14);

        }
    }
}
