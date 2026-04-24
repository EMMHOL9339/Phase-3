public class Department
{
    public string DepartmentName { get; private set; }
    public string ManagerName { get; private set; }

    public Department(string departmentName, string managerName)
    {
        DepartmentName = departmentName;
        ManagerName = managerName;
    }

    public override string ToString()
    {
        return DepartmentName + " Department, Manager: " + ManagerName;
    }
}