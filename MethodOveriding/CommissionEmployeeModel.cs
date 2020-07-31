namespace MethodOveriding
{
    public class CommissionEmployeeModel : EmployeeModel
    {
        public decimal CommissionAmount { get; set; }

        public override decimal GetPaycheckAmount(int hoursWorked)
        {
            decimal initialPlay = base.GetPaycheckAmount(hoursWorked);
            return initialPlay + CommissionAmount;
        }
    }
}
