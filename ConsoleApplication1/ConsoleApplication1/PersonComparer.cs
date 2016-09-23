using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class PersonComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person x, Person y)
        {
            if(x.GetHashCode() == y.GetHashCode() && x == y)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode() ^ obj.Age;
        }
    }
}
