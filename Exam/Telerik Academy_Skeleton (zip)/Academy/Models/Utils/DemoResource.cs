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
    public class DemoResource : Resource, ILectureResouce
    {
        public DemoResource(string name, string url)
            : base(name, url)
        {
        }        
    }
}
