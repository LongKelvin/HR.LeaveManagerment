namespace HR.LeaveManagerment.Application.Models.Identity
{
    public class Employee
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Employee()
        {
            Id = string.Empty;
            Email = string.Empty;
            Firstname = string.Empty;
            Lastname = string.Empty;
        }
    }
}
