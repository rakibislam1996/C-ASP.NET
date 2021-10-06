using System;
using System.Collections.Generic;

namespace OverrideMethods
{
    class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public Student() { }
            public Student(int Id, string Name)
            {
                this.Id = Id;
                this.Name = Name;
            }
            
            public override string ToString()
            {
                return Name;
            }
            public override bool Equals(object obj)
            {
                if (Name == ((Student)obj).Name)
                    return true;
                return false;
            }
            public override int GetHashCode()
            {
                return Name.GetHashCode();
            }
        }
        static void Main(string[] args)
        {
            Student st = new Student(101,"Rakib");
            Console.WriteLine(st);  // calls ToString() method

            Student st1 = new Student(101, "Rakib");
            Console.WriteLine(st.Equals(st1));  // calls Equals() method

            Console.WriteLine(st1.GetHashCode());  // calls GetHashCode()
        }
    }
}
