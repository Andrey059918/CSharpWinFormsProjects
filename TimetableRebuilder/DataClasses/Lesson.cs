using System;

namespace TimetableRebuilder.DataClasses
{
    public class Lesson
    {
        //Fields
        public String _Name { get; private set; }
        public String _Type { get; private set; }
        public String _Teacher { get; private set; }
        public String _Classroom { get; private set; }
        //Constructors
        public Lesson(String name, String type, String teacher, String classroom)
        {
            _Name = name;
            _Type = type;
            _Teacher = teacher;
            _Classroom = classroom;
        }
    }
}
