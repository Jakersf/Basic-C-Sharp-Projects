using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new StudentContext())
            {
                var stud = new Student() { StudentName = "Bill " };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }

            
        }
    }
    
}
