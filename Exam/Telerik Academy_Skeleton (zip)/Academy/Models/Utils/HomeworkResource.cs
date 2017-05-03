using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Models.Utils
{
    public class HomeworkResource : Resource, ILectureResouce
    {
        private const byte HOMEWORK_DURATION = 7;
        private readonly DateTime dueDate;

        public HomeworkResource(string name, string url, DateTime now) 
            : base(name, url)
        {
            this.dueDate = now.AddDays(HOMEWORK_DURATION);
        }

        public DateTime DueDate
        {
            get
            {
                return this.dueDate;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(base.ToString());
            builder.AppendLine(string.Format(" - Due date: {0:yyyy-MM-dd hh:mm:ss tt}", this.DueDate));

            return builder.ToString();
        }
    }
}
