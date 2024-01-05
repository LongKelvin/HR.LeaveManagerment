using HR.LeaveManagement.Domain.Commons;

namespace HR.LeaveManagement.Domain.Entities
{
    public class LeaveType : BaseDomainEntity
    {
        public string? Name { get; set; }
        public int DefaultDays { get; set; }
    }
}
