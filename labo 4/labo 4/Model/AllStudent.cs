using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo_4.Model
{
    public static class AllStudent
    {
        public static IEnumerable<Student> Students { get; set; }

        public static IEnumerable<Student> GetAllStudents()
        {
            return Students = new List<Student>
            {
                new Student("oli",21),
                new Student("anto",20),
                new Student("augu",19),
            };
        }
    }
}
