using System;

namespace AccessModifiers
{
    class Person // By default internal
    {
        public int Age { get; set; } // By default private
        public void publicMethod() // By default private
        {
            Console.WriteLine("Public Method of Person");
            internalMethod();
            protectedInternalMethod();
            protectedMethod();
            privateProtectedMethod();
            privateMethod();
            Console.WriteLine();
        }
        internal void internalMethod()
        {
            Console.WriteLine("Internal Method of Person");
        }
        protected internal void protectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method of Person");
        }
        protected void protectedMethod()
        {
            Console.WriteLine("Protected Method of Person");
        }
        private protected void privateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method of Person");
        }
        private void privateMethod()
        {
            Console.WriteLine("Private Method of Person");
        }
    }
    class Student : Person // By default internal
    {
        public void FuncStudent()
        {
            Console.WriteLine("Public Method of Student");
            publicMethod();
            internalMethod();
            protectedMethod();
            protectedInternalMethod();
            privateProtectedMethod();
            //privateMethod();
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.publicMethod();
            person.internalMethod();
            person.protectedInternalMethod();
            //person.protectedMethod();
            //person.privateProtectedMethod();
            //person.privateMethod();
            Console.WriteLine();
            Student student = new Student();
            student.FuncStudent();
            student.publicMethod();
            student.internalMethod();
            student.protectedInternalMethod();
            //student.protectedMethod();
            //student.privateProtectedMethod();
            //student.privateMethod();
        }
    }
}
