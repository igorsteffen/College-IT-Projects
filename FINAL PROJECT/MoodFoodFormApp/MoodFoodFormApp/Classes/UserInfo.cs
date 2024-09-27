using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodFoodFormApp.Classes
{
    public class UserInfo
    {
        private string mood;
        private string time;
        private string restrictions;

        public UserInfo() { }

        public UserInfo(string mood, string time, string restrictions)
        {
            this.mood = mood;
            this.time = time;
            this.restrictions = restrictions;
        }

        public string Mood { get => mood; set => mood = value; }
        public string Time { get => time; set => time = value; }
        public string Restrictions { get => restrictions; set => restrictions = value; }
    }
}
