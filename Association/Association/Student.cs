using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Student
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public Address stuAddress { get; set; }
        public Student() { }
        public Student(int Id, String Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
    }
}
