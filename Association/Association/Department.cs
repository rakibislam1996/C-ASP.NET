using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Association
{
    class Department
    {
        public string DeptName { get; set; }
        public List<Student> students { get; set; }
    }

}
