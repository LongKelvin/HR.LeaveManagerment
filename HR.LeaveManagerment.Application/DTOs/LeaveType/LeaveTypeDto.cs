using HR.LeaveManagerment.Application.DTOs.Common;

namespace HR.LeaveManagerment.Application.DTOs.LeaveType
{
    public class LeaveTypeDto : BaseDto, ILeaveTypeDto
    {
        public string Name { get; set; } = string.Empty;
        public int DefaultDays { get; set; }
    }
}
