using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2_draft
{
    internal class Person
    {
        private string name;
        private string citizenship;

        public Person()
        {
        }

        public Person(string name, string citizenship)
        {
            this.name = name;
            this.citizenship = citizenship;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetCitizenship()
        {
            return citizenship;
        }

        public void SetCitizenship(string citizenship)
        {
            this.citizenship = citizenship;
        }

        public override string ToString()
        {
            return GetName() + GetCitizenship();
        }
    }
}
