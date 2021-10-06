using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetterSetter
{
    class Student1   // get set using normal method
    {
        private int id;
        private string name;

        public void SetId(int id)
        {
            if (id < 0)
                throw new Exception("Id is invalid");
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new Exception("Name is invalid");
            this.name = name;
        }
        public string GetName()
        {
            return this.name;
        }

    }
}
