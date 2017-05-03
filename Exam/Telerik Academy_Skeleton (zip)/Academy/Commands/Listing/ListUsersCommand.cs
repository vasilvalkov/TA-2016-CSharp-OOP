using System;
using System.Collections.Generic;
using Academy.Commands.Contracts;
using Academy.Core.Contracts;
using System.Text;

namespace Academy.Commands.Listing
{
    public class ListUsersCommand : ICommand
    {
        private readonly IAcademyFactory factory;
        private readonly IEngine engine;

        public ListUsersCommand(IAcademyFactory factory, IEngine engine)
        {
            this.factory = factory;
            this.engine = engine;
        }

        public string Execute(IList<string> parameters)
        {
            var builder = new StringBuilder();

            foreach (var trainer in this.engine.Trainers)
            {
                builder.AppendLine(trainer.ToString());
            }

            foreach (var student in this.engine.Students)
            {
                builder.AppendLine(student.ToString().TrimEnd());
            }

            return builder.ToString();
        }
    }
}
