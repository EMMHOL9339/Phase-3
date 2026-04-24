public abstract class Employee : IPayable
{
    public int EmployeeId { get; private set; }
    public string Name { get; protected set; }
    public string Position { get; protected set; }
    public Department DepartmentInfo { get; private set; }

    public Employee(int employeeId, string name, string position, Department departmentInfo)
    {
        EmployeeId = employeeId;
        Name = name;
        Position = position;
        DepartmentInfo = departmentInfo;
    }

    public abstract double CalculatePay();

    public virtual string GetEmployeeInfo()
    {
        return "ID: " + EmployeeId +
               "\nName: " + Name +
               "\nPosition: " + Position +
               "\nDepartment: " + DepartmentInfo;
    }

    public override string ToString()
    {
        return GetEmployeeInfo() +
               "\nPay: $" + CalculatePay().ToString("F2");
    }
}