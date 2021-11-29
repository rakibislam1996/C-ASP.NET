class Person
{
    public int id { get; set; }
    public int age { get; set; }
    static Person() { Console.WriteLine("Default Constructor"); }
    public Person(int id, int age)
    {
        this.id = id;
        this.age = age;
    }
}
class Student : Person
{
    static Student() { }
    public Student(int id, int age) : base(id, age) { }  // Calling Base Class Constructor
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person(11608009, 25);
        Console.WriteLine(person.age+" "+person.id);

        Person person1 = new Person(101, 30);
        Console.WriteLine(person1.age+" "+person1.id);

        Student student = new Student(11608010, 30);
        Console.WriteLine(student.id+" "+student.age);

        List<Student> stuList = new List<Student>()
            {
                new Student(1,25),
                new Student(2,26)
            };
        Console.WriteLine(stuList[0].id+" "+stuList[1].age);
    }
}