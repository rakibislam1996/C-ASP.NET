using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace QueryOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 21, GuardianID = 1 },
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, GuardianID = 2 },
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 17 },
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 21 },
                new Student() { StudentID = 5, StudentName = "Rob" , Age = 31, GuardianID = 3 },
                new Student() { StudentID = 6, StudentName = "Chris",  Age = 17, GuardianID = 1 },
                new Student() { StudentID = 7, StudentName = "Rob",Age = 39, GuardianID = 3  },
            };
            List<Guardian> guardians = new List<Guardian>
            {
                new Guardian(){ GuardianID = 1, GuardianName="John Cena"},
                new Guardian(){ GuardianID = 2, GuardianName="Steve Austin"},
                new Guardian(){ GuardianID = 3, GuardianName="Rob Van"}
            };
            // Where in Query Syntax

            var studentList = from stu in students
                              where stu.Age>12 && stu.Age <20
                              select stu;
            Student aStudent;
            try
            {
                aStudent = (from stu in students
                                    where stu.StudentID == 8
                                    select stu).First();
            }
            catch(InvalidOperationException) 
            {
                aStudent = new Student() { StudentID = 8};
                students.Add(aStudent);
            }


            // Where in Method Syntax
            var studentList2 = students.Where((student, index) => student.Age>12 && student.Age<20);
            Student student2 = students.Where(s => s.StudentName == "Chris").FirstOrDefault();

            ArrayList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);

            // OfType in Query Syntax

            var result = from s in mixedList.OfType<string>()
                         select s;
            var result2 = from s in mixedList.OfType<int>()
                          select s;

            // OfType in Method Syntax
            var result3 = mixedList.OfType<string>();
            var result4 = mixedList.OfType<int>();

            // OrderBy in Query Syntax

            var orderByresult = from s in students
                                orderby s.StudentName
                                select s;
            orderByresult = from s in students
                            orderby s.StudentName, s.Age descending
                            select s;
            //foreach (var item in orderByresult)
            //  Console.WriteLine(item.StudentName+" "+item.Age);

            // OrderBy in Method Syntax

            orderByresult = students.OrderBy(s => s.StudentName);
            orderByresult = students.OrderByDescending(s => (s.StudentName, s.Age));

            // ThenBy in Method Syntax

            orderByresult = students.OrderBy(s => s.StudentName).ThenBy(s => s.Age);
            orderByresult = students.OrderByDescending(s => s.StudentName).ThenBy(s => s.Age);

            // GroupBy in Query Syntax

            var groupByresult = from s in students
                                group s by s.Age;

            //foreach (var age in groupByresult)
            //{
            //    Console.WriteLine(age.Key);
            //    foreach (Student s in age)
            //        Console.WriteLine(s.StudentName);
            //}

            // GroupBy in Method Syntax

            var groupByresult2 = students.GroupBy(s => s.StudentName);

            // ToLookUp in Method Syntax

            var ToLookUpResult = students.ToLookup(s => s.StudentName);

            // Join in Query Syntax

            var innerJoin = (from student in students
                             join gurdian in guardians
                             on student.GuardianID equals gurdian.GuardianID
                             where student.GuardianID==1
                             select new {
                                 StudentName = student.StudentName,
                                 GuardianName = gurdian.GuardianName
                             });
            //string str = "John".;
            //foreach (var item in innerJoin)
            //    Console.WriteLine(item.StudentName+" is child of "+item.GuardianName);
            //Console.WriteLine();

            // Join in Method Syntax

            var innerJoin2 = students.Join(guardians,
                                student => student.GuardianID,
                                gurdian => gurdian.GuardianID,
                                (student, gurdian) => new {
                                    StudentName = student.StudentName,
                                    GuardianName = gurdian.GuardianName
                                });

            //foreach (var item in innerJoin2)
            //    Console.WriteLine(item.StudentName+" is child of "+item.GuardianName);

            IList<string> strList1 = new List<string>() { "One", "Two", "Three", "Four" };

            IList<string> strList2 = new List<string>() { "One", "Two", "Five", "Six" };

            // Join in Query Syntax

            var innerJoin4 = from str1 in strList1
                             join str2 in strList2
                             on str1 equals str2
                             select str1;

            // Join in Method Syntax

            var innerJoin3 = strList1.Join(strList2,
                                  str1 => str1,
                                  str2 => str2,
                                  (str1, str2) => str1);

            // GroupJoin in Query Syntax

            var groupJoin = from gurd in guardians
                            join stu in students
                            on gurd.GuardianID equals stu.GuardianID
                            into studentGroup
                            select new {
                                StudentGroup = studentGroup,
                                GuardianName = gurd.GuardianName
                                //StudentName = stu.GuardianName
                            };

            //foreach (var item in groupJoin)
            //{
            //    Console.WriteLine(item.GuardianName + " -> ");
            //    foreach (var s in item.StudentGroup)
            //        Console.WriteLine(s.StudentName);
            //}

            // GroupJoin in Method Syntax

            var groupJoin2 = guardians.GroupJoin(students,
                                  gurd => gurd.GuardianID,
                                  stu => stu.GuardianID,
                                  (gurd, studentGroup) => new {
                                      StudentGroup = studentGroup,
                                      GuardianName = gurd.GuardianName
                                  });
            //foreach (var item in groupJoin2)
            //{
            //    Console.WriteLine(item.GuardianName + " -> ");
            //    foreach (var s in item.StudentGroup)
            //        Console.WriteLine(s.StudentName);
            //}
        }

    }
}
