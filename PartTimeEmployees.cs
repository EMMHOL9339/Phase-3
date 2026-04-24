public class PartTimeEmployee : Employee
{
    public double HourlyRate { get; private set; }
    public double HoursWorked { get; private set; }

    public PartTimeEmployee(int employeeId, string name, string position,
        Department departmentInfo, double hourlyRate, double hoursWorked)
        : base(employeeId, name, position, departmentInfo)
    {
        HourlyRate = hourlyRate;
        HoursWorked = hoursWorked;
    }

    public override double CalculatePay()
    {
        return HourlyRate * HoursWorked;
    }

    public override string ToString()
    {
        return "Part-Time Employee\n" +
               base.ToString() +
               "\nHourly Rate: $" + HourlyRate.ToString("F2") +
               "\nHours Worked: " + HoursWorked;
    }
}