using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Models
{
    public class Group
    {
        private ushort groupNumber;
        private string department;

        public ushort GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
        }
        public string DepartmentName
        {
            get
            {
                return this.department;
            }
        }
    }
}
