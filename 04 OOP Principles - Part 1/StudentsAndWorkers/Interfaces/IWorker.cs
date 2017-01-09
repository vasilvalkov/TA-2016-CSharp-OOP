namespace StudentsAndWorkers
{
    public interface IWorker
    {
        byte WorkDays { get; set; }
        decimal WeekSalary { get; set; }
        byte WorkHoursPerDay { get; set; }

        decimal MoneyPerHour();
    }
}
