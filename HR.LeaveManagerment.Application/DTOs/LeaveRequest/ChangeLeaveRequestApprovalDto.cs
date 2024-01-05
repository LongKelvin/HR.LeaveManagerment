using HR.LeaveManagerment.Application.DTOs.Common;

namespace HR.LeaveManagerment.Application.DTOs.LeaveRequest
{
    public class ChangeLeaveRequestApprovalDto : BaseDto
    {
        public bool Approved { get; set; }
    }
}
