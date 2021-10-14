using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    public class Student
    {
    }
    public class StudentsList
    {
        public List<Student> Students { get; set; } = new List<Student>();
        public void Add(Student student)
        {
            Students.Add(student);
            Console.WriteLine($"You are student no. {Students.Count}");
            if (Students.Count % 5 == 0)
            {
                if (discountMessage != null)
                {
                    discountMessage();
                }
            }
        }

        public static void DiscountMessage()
        {
            Console.WriteLine("You get 5% discount");
        }

        public static event PrintMessage discountMessage;
    }
}
