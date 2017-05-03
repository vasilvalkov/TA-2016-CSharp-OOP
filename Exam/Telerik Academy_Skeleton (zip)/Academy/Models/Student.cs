using Academy.Models.Contracts;
using Academy.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;

namespace Academy.Models
{
    public class Student : Person, IStudent, IUser
    {
        private Track track;
        private IList<ICourseResult> courseResults;

        public Student(string userName, Track track)
            : base(userName)
        {
            this.Track = track;
            this.CourseResults = new List<ICourseResult>();
        }

        public IList<ICourseResult> CourseResults
        {
            get
            {
                return this.courseResults;
            }

            set
            {
                this.courseResults = value;
            }
        }

        public Track Track
        {
            get
            {
                return this.track;
            }

            set
            {
                this.track = value;
            }
        }      

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Student");
            builder.AppendLine(string.Format(" - Username: {0}", this.Username));
            builder.AppendLine(string.Format(" - Track: {0}", this.Track));
            builder.AppendLine(" - Course results:");
            if (this.CourseResults.Count == 0)
            {
                builder.AppendLine(string.Format("  * User has no course results!"));
            }
            else
            {
                foreach (var result in this.CourseResults)
                {
                    builder.AppendLine(result.ToString().Trim());
                }
            }

            return builder.ToString().Trim();
        }
    }
}
