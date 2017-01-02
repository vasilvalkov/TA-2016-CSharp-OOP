namespace App.Models
{
    public class Group
    {
        private ushort groupNumber;
        private string department;

        public Group(ushort number, string department)
        {
            this.GroupNumber = number;
            this.DepartmentName = department;
        }

        public ushort GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }
        public string DepartmentName
        {
            get
            {
                return this.department;
            }
            set
            {
                this.department = value;
            }
        }
    }
}