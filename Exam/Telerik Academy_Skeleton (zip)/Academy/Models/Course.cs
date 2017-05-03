using Academy.Models.Contracts;
using Academy.Models.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    class Course : ICourse
    {
        private const byte MIN_NUMBER_OF_LECTURES = 1;
        private const byte MAX_NUMBER_OF_LECTURES = 7;
        private const byte MIN_LENGTH_OF_NAME = 3;
        private const byte MAX_LENGTH_OF_NAME = 45;
        private string name;
        private int lecturesPerWeek;
        private IList<IStudent> onsiteStudents;
        private IList<IStudent> onlineStudents;
        private DateTime startingDate;
        private DateTime endingDate;

        public Course(string name, int lecturesPerWeek, DateTime startingDate)
        {
            this.Name = name;
            this.LecturesPerWeek = lecturesPerWeek;
            this.StartingDate = startingDate;
            this.endingDate = this.StartingDate.AddDays(30);
            this.Lectures = new List<ILecture>();
            this.onlineStudents = new List<IStudent>();
            this.onsiteStudents = new List<IStudent>();
        }

        public DateTime EndingDate
        {
            get
            {
                return this.endingDate;
            }

            set
            {
                this.endingDate = value;
            }
        }

        public IList<ILecture> Lectures
        {
            get;
            set;
        }

        public int LecturesPerWeek
        {
            get
            {
                return this.lecturesPerWeek;
            }

            set
            {
                if (value < MIN_NUMBER_OF_LECTURES || value > MAX_NUMBER_OF_LECTURES)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The number of lectures per week must be between {0} and {1}!", MIN_NUMBER_OF_LECTURES, MAX_NUMBER_OF_LECTURES));
                }

                this.lecturesPerWeek = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length < MIN_LENGTH_OF_NAME || value.Length > MAX_LENGTH_OF_NAME)
                {
                    throw new ArgumentOutOfRangeException(string.Format("The name of the course must be between {0} and {1} symbols!", MIN_LENGTH_OF_NAME, MAX_LENGTH_OF_NAME));
                }

                this.name = value;
            }
        }

        public IList<IStudent> OnlineStudents
        {
            get
            {
                return this.onlineStudents;
            }
        }

        public IList<IStudent> OnsiteStudents
        {
            get
            {
                return this.onsiteStudents;
            }
        }

        public DateTime StartingDate
        {
            get
            {
                return this.startingDate;
            }

            set
            {
                this.startingDate = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Course");
            builder.AppendLine(string.Format(" - Name: {0}", this.Name));
            builder.AppendLine(string.Format(" - Lectures per week: {0}", this.LecturesPerWeek));
            builder.AppendLine(string.Format(" - Starting date: {0:yyyy-MM-dd hh:mm:ss tt}", this.StartingDate));
            builder.AppendLine(string.Format(" - Ending date: {0:yyyy-MM-dd hh:mm:ss tt}", this.EndingDate));
            builder.AppendLine(string.Format(" - Onsite students: {0}", this.OnsiteStudents.Count));
            builder.AppendLine(string.Format(" - Online students: {0}", this.OnlineStudents.Count));
            builder.AppendLine(string.Format(" - Lectures:"));
            if (this.Lectures.Count == 0)
            {
                builder.AppendLine(string.Format("  * There are no lectures in this course!"));
            }
            else
            {
                foreach (var lecture in this.Lectures)
                {
                    builder.AppendLine(lecture.ToString());
                }
            }

            return builder.ToString();
        }
    }
}
