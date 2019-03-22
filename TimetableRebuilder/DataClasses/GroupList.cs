using System;
using System.Collections.Generic;
using System.Linq;

namespace TimetableRebuilder.DataClasses
{
    public class GroupList
    {
        //Fields
        private Dictionary<String, Group> _Groups;
        //Constructors
        public GroupList()
        {
            _Groups = new Dictionary<string, Group>();
        }
        //Properties
        public int GroupCount => _Groups.Count;
        //Indexators
        public Group this[int index] => _Groups.ElementAt(index).Value;
        public Group this[String name] => _Groups[name];
        //Methods
        public void AddGroup(String name)
        {
            _Groups.Add(name, new Group(name));
        }
        public int MaxLessonsCount(int day)=> Math.Max(_Groups.Select(a => (a.Value.DaysCount(0)>day)?a.Value.DayLessonsCount(0,day):0).Max(),_Groups.Select(a => (a.Value.DaysCount(1) > day) ? a.Value.DayLessonsCount(1, day) : 0).Max());
        
    }
}
