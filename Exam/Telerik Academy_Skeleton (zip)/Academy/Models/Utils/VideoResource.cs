using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;


namespace Academy.Models.Utils
{
    public class VideoResource : Resource, ILectureResouce
    {
        private readonly DateTime uploadedOn;

        public VideoResource(string name, string url, DateTime uploadedOn) 
            : base(name, url)
        {
            this.uploadedOn = uploadedOn;
        }

        public DateTime UploadedOn
        {
            get
            {
                return this.uploadedOn;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append(base.ToString());
            builder.Append(string.Format(" - Uploaded on: {0:yyyy-MM-dd hh:mm:ss tt}", this.UploadedOn));

            return builder.ToString().Trim();
        }
    }
}
