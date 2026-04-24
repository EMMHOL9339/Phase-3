public class ContractEmployee : Employee
{
    public double ContractPay { get; private set; }
    public int ContractLengthMonths { get; private set; }

    public ContractEmployee(int employeeId, string name, string position,
        Department departmentInfo, double contractPay, int contractLengthMonths)
        : base(employeeId, name, position, departmentInfo)
    {
        ContractPay = contractPay;
        ContractLengthMonths = contractLengthMonths;
    }

    public override double CalculatePay()
    {
        return ContractPay / ContractLengthMonths;
    }

    public override string ToString()
    {
        return "Contract Employee\n" +
               base.ToString() +
               "\nContract Pay: $" + ContractPay.ToString("F2") +
               "\nContract Length: " + ContractLengthMonths + " months";
    }
}