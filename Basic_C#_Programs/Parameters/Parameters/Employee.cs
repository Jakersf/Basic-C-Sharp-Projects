using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters
{
    public class Employee <T>
    {
        public List<T> Things { get; set; } //Creates a list property named Things with a generic data type
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        



    }
}
