using HR.LeaveManagerment.Application.DTOs.Common;
using HR.LeaveManagerment.Application.DTOs.LeaveType;
using HR.LeaveManagerment.Application.Models.Identity;

namespace HR.LeaveManagerment.Application.DTOs.LeaveRequest
{
    public class LeaveRequestListDto : BaseDto
    {
        public Employee Employee { get; set; }
        public string RequestingEmployeeId { get; set; }
        public LeaveTypeDto LeaveType { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool? Approved { get; set; }

        public LeaveRequestListDto()
        {
            LeaveType = new LeaveTypeDto();
            RequestingEmployeeId = string.Empty;
            Employee = new Employee();
        }
    }
}
