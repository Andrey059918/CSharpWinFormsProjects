using System;
using System.Linq;
using System.Collections.Generic;

namespace TimetableRebuilder.DataClasses
{
    public class WeekDay
    {
        //Fields
        private List<Lesson> Lessons;
        //Constructors
        public WeekDay()
        {
            Lessons = new List<Lesson>();
        }
        //Properties
        public Int32 LessonsCount => Lessons.Count;
        //Indexators
        public Lesson this[int number] => Lessons[number];
        //Methods
        public void AddLesson(String name,String type, String teacher,String classroom) {
            Lessons.Add(new Lesson(name,type,teacher,classroom));
        }
        public void RemoveBlankLessons() {
            Lessons.Reverse();
            Lessons = Lessons.SkipWhile(a => a._Name == "" || a._Name == "День" || a._Name == "самостоятельных" || a._Name == "занятий").ToList();
            Lessons.Reverse();
        }
    }
}
