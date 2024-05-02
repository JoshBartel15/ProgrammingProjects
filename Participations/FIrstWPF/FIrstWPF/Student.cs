using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FIrstWPF
{
    public class Student
    {
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }

        public Student()
        {
            Name = string.Empty;
            Birthdate = DateTime.Now;
        }

        public int CalculateAge()
        {
            int age = 0;
            age = DateTime.Now.Year - Birthdate.Year;
            if (DateTime.Now.DayOfYear < Birthdate.DayOfYear)
            {
                age = age - 1;
            }
            return age;
        }
    }
}
