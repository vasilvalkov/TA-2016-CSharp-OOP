using Academy.Models.Utils.Contracts;
using Academy.Models.Contracts;
using Academy.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Lecture : ILecture
    {
        private const byte MIN_NAME_LENGTH = 5;
        private const byte MAX_NAME_LENGTH = 30;
        private string name;
        private DateTime date;
        private ITrainer trainer;
        private IList<ILectureResouce> resource;

        public Lecture(string name, DateTime date, ITrainer trainer)
        {
            this.Resouces = new List<ILectureResouce>();
            this.Name = name;
            this.Date = date;
            this.Trainer = trainer;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length < MIN_NAME_LENGTH || value.Length > MAX_NAME_LENGTH)
                {
                    throw new ArgumentException(string.Format("Lecture's name should be between {0} and {1} symbols long!",
                        MIN_NAME_LENGTH, MAX_NAME_LENGTH));
                }

                this.name = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return this.date;
            }

            set
            {
                this.date = value;
            }
        }

        public IList<ILectureResouce> Resouces
        {
            get
            {
                return this.resource;
            }
            set
            {
                this.resource = value;
            }
        }

        public ITrainer Trainer
        {
            get
            {
                return this.trainer;
            }

            set
            {
                this.trainer = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Lecture");
            builder.AppendLine(string.Format(" - Name: {0}", this.Name));
            builder.AppendLine(string.Format(" - Date: {0:yyyy-MM-dd hh:mm:ss tt}", this.Date));
            builder.AppendLine(string.Format(" - Trainer username: {0}", this.trainer.Username));
            builder.AppendLine(" - Resources:");
            if (this.Resouces.Count == 0)
            {
                builder.Append(string.Format("  * There are no resources in this lecture."));
            }
            else
            {
                foreach (var resource in this.Resouces)
                {
                    builder.AppendLine(resource.ToString());
                }
            }

            return builder.ToString().Trim();
        }
    }
}
