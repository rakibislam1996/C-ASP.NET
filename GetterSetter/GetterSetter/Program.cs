using System;

namespace GetterSetter
{
    
    class Program   
    {
        class Student // using prop get set
        {
            public Student() { }
            public Student(int Id, string Name, string Dept) 
            {
                this.Id = Id;
                this.Name = Name;
                this.Dept = Dept;
            }
            public int Id { get; set; }
            public string Name { get; set; }
            public string Dept { get; set; }
       }
        static void Main(string[] args)
        {
            Student[] stu = new Student[] { 
                new Student(1, "Shafi", "EEE"),
                new Student(2, "Tanvir", "CSE"),
                new Student(3, "Robin", "Civil")
            };
            foreach (var item in stu)
            {
                Console.WriteLine($"Name: {item.Name}, Dept: {item.Dept}, Id: {item.Id}");
            }

            foreach (var item in stu)
            {
                item.Id = int.Parse(Console.ReadLine());
                item.Name = Console.ReadLine();
                item.Dept = Console.ReadLine();
            }
            foreach (var item in stu)
            {
                Console.WriteLine($"Name: {item.Name}, Dept: {item.Dept}, Id: {item.Id}");
            }

            Student student2 = new Student(1,"Shafi","EEE");
            Console.WriteLine($"Name: {student2.Name}, Dept: {student2.Dept}, Id: {student2.Id}");

            Student student = new Student();
            student.Id = 100;
            student.Name = "Rakib";
            student.Dept = "CSE";
            Console.WriteLine("Name: {0}, Dept: {1}, Id: {2}", student.Name, student.Dept, student.Id);

            //Student2 student2 = new Student2();
            //student2.Id = 100;
            //Console.WriteLine(student2.Id);
            //student2.Name = "Sakib";
            //Console.WriteLine(student2.Name);

            //Student1 st = new Student1();
            //st.SetId(10);
            //Console.WriteLine(st.GetId());
            //st.SetName("Rakib");
            //Console.WriteLine(st.GetName());

        }
    }
}
