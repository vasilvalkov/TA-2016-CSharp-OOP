namespace StudentsAndWorkers
{
    public class Worker : Human, IWorker
    {
        public Worker(string firstName, string lastName, decimal weekSalary, byte workHoursPerDay, byte workDays)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDays = workDays;
        }

        public byte WorkDays { get; set; }
        public decimal WeekSalary { get; set; }
        public byte WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * this.WorkDays);
        }
    }
}