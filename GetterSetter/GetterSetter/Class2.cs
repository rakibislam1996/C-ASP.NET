using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Student2 // get set using get and set keyword with if cond.
    {
        private int id;
        private string name;
        public int Id
        {
            set
            {
                if (value < 0)
                    throw new Exception("Id is invalid");
                this.id = value;
            }
            get
            {
                return this.id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("Name is invalid");
                this.name = value;
            }
            get
            {
                return this.name;
            }
        }
    }
}
