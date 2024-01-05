using HR.LeaveManagement.Domain.Commons;

namespace HR.LeaveManagement.Domain.Entities
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int NumberOfDays { get; set; }
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
        public string EmployeeId { get; set; }

        public LeaveAllocation()
        {
            LeaveType = new LeaveType();
            EmployeeId = string.Empty;
        }

    }
}
