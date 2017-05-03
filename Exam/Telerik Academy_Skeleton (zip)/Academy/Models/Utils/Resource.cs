using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Utils.Contracts;
using Academy.Models.Contracts;
using Academy.Models.Enums;

namespace Academy.Models.Utils
{
    public abstract class Resource : ILectureResouce
    {
        private const byte MIN_NAME_LENGTH = 3;
        private const byte MAX_NAME_LENGTH = 15;
        private const byte MIN_URL_LENGTH = 5;
        private const byte MAX_URL_LENGTH = 150;
        private string name;
        private string url;

        public Resource(string name, string url)
        {
            this.Name = name;
            this.Url = url;
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
                    throw new ArgumentException(string.Format("Resource name should be between {0} and {1} symbols long!", MIN_NAME_LENGTH, MAX_NAME_LENGTH));
                }

                this.name = value;
            }
        }

        public string Url
        {
            get
            {
                return this.url;
            }

            set
            {
                if (value.Length < MIN_URL_LENGTH || value.Length > MAX_URL_LENGTH)
                {
                    throw new ArgumentException(string.Format("Resource url should be between {0} and {1} symbols long!", MIN_URL_LENGTH, MAX_URL_LENGTH));
                }

                this.url = value;
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Resource");
            builder.AppendLine(string.Format(" - Name: {0}", this.Name));
            builder.AppendLine(string.Format(@" - Url: {0}", this.Url));
            builder.AppendLine(string.Format(" - Type: {0}", this.GetType().Name.Replace("Resource", string.Empty)));

            return builder.ToString().Trim();
        }
    }
}
