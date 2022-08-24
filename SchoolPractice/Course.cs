using System;
using System.Collections.Generic;
using System.Linq;

namespace SchoolPractice
{
    public class Course
    {
        public string Topic { get; set; }
        public Teacher Instructor { get; set; }
        public List<Student> enrolledStudents { get; set; }


        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather than
        //  just the class fields.


        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Course objects equal.

        public override string ToString()
        {
            return Topic + Instructor.ToString() + "Students Enrolled : \n" + String.Join("\n", enrolledStudents.Select(x => x.ToString()).ToArray());
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            Course courseObj = obj as Course;
            return Topic == courseObj.Topic;
        }
    }
}
