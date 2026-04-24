public class FullTimeEmployee : Employee
{
    public double AnnualSalary { get; private set; }

    public FullTimeEmployee(int employeeId, string name, string position,
        Department departmentInfo, double annualSalary)
        : base(employeeId, name, position, departmentInfo)
    {
        AnnualSalary = annualSalary;
    }

    public override double CalculatePay()
    {
        return AnnualSalary / 12;
    }

    public override string ToString()
    {
        return "Full-Time Employee\n" +
               base.ToString() +
               "\nAnnual Salary: $" + AnnualSalary.ToString("F2");
    }
}