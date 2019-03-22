using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimetableRebuilder.DataClasses
{
    class DataStorage
    {
        //DataArray
        public Dictionary<String, List<List<List<Lesson>>>> GroupList { get; private set; }
        //Constructor
        public DataStorage() {
            GroupList = new Dictionary<string, List<List<List<Lesson>>>>();
        }
        //AddEntries
        public void AddGroup(String group) {
            GroupList.Add(group, new List<List<List<Lesson>>>());
        }
        public void AddWeek(String group)
        {
            GroupList[group].Add(new List<List<Lesson>>());
        }
        public void AddDay(String group,Int32 week)
        {
            GroupList[group][week].Add(new List<Lesson>());
        }
        public void AddLesson(String groupname, Int32 week, Int32 day,params String[] lessoninfo)
        {
            GroupList[groupname][week][day].Add(new Lesson(lessoninfo[0], lessoninfo[1],lessoninfo[2],lessoninfo[3]));
        }
        //Optimizers
        public void RemoveBlankLessons()
        {
            string[] arr = new string[4] { "", "День", "самостоятельных", "занятий" };
            for (int day = 0; day < 6; day++)
            {
                while (GroupList.All(a => a.Value.All(b => b[day].Count>0&&arr.Contains(b[day].Last()._Name))))
                {
                    foreach (KeyValuePair<String, List<List<List<Lesson>>>> eachgroup in GroupList)
                    {
                        foreach (List<List<Lesson>> eachweek in eachgroup.Value)
                        {
                            eachweek[day].Remove(eachweek[day].Last());
                        }
                    }
                }
            }
        }
        public void RemoveBlankDays()
        {
            while (GroupList.All(a => a.Value.All(b => b.Last().Count == 0)))
            {
                foreach (KeyValuePair<String, List<List<List<Lesson>>>> eachgroup in GroupList)
                {
                    foreach (List<List<Lesson>> eachweek in eachgroup.Value)
                    {
                        eachweek.Remove(eachweek.Last());
                    }
                }
            }
        }
     





    }
}
