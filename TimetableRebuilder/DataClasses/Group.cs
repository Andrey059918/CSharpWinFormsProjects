using System;
using System.Linq;
using System.Collections.Generic;

namespace TimetableRebuilder.DataClasses
{
    public class Group
    {
        //Fields
        private List<WeekDay> _OddWeek;
        private List<WeekDay> _EvenWeek;
        //Constructors
        public Group(String name)
        {
            _Name = name;
            _OddWeek = new List<WeekDay>();
            _EvenWeek = new List<WeekDay>();
            for (int i = 0; i < 6; i++)
            {
                _OddWeek.Add(new WeekDay());
                _EvenWeek.Add(new WeekDay());
            }
        }
        //Properties
        public String _Name { get; private set; }
        //Indexators
        public WeekDay this[int oddeven, int day] => (oddeven == 0) ? (_OddWeek[day]) : (_EvenWeek[day]);
        //Methods
        public Int32 DayLessonsCount(int week,int day) {
            return (week==0)?(_OddWeek[day].LessonsCount):(_EvenWeek[day].LessonsCount);
        }
        public int DaysCount(int week)
        {
            return (week == 0)?(_OddWeek.Count):(_EvenWeek.Count);
        }
        public void RemoveBlankDays() {
            _OddWeek.Reverse();
            _EvenWeek.Reverse();
            _OddWeek = _OddWeek.SkipWhile(a => a.LessonsCount == 0).ToList();
            _EvenWeek = _EvenWeek.SkipWhile(a => a.LessonsCount == 0).ToList();
            _OddWeek.Reverse();
            _EvenWeek.Reverse();
        }
    }
}
