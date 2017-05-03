using Academy.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy.Models
{
    public class Trainer : Person, ITrainer, IUser
    {        
        
        private IList<string> technologies;

        public Trainer (string username, string technologies)
            : base(username)
        {            
            var splitedTechnologies = technologies.Split(new char[] { ' ', ',', ';'}, StringSplitOptions.RemoveEmptyEntries);
            this.Technologies = new List<string>(splitedTechnologies);
        }

        public IList<string> Technologies
        {
            get
            {
                return this.technologies;
            }

            set
            {
                this.technologies = value;
            }
        }


        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine("* Trainer");
            builder.AppendLine(string.Format(" - Username: {0}", this.Username));
            builder.AppendLine(string.Format(" - Technologies: {0}", string.Join("; ", this.Technologies)));

            return builder.ToString().Trim();
        }
    }
}
