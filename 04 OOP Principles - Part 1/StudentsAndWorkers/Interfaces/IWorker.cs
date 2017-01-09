namespace StudentsAndWorkers
{
    public interface IWorker : IHuman
    {
        byte WorkDays { get; set; }
        decimal WeekSalary { get; set; }
        byte WorkHoursPerDay { get; set; }

        decimal MoneyPerHour();
    }
}
