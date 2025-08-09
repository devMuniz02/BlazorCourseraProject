using System.Collections.Generic;

namespace CourseraBlazor.Services
{
    public class UserSessionService
    {
        public string? UserName { get; set; }
        public string? UserEmail { get; set; }

    public List<string> RegisteredEvents { get; } = new();
    public List<string> AttendedEvents { get; } = new();

        public void Register(string eventName, string userName, string userEmail)
        {
            UserName = userName;
            UserEmail = userEmail;
            if (!RegisteredEvents.Contains(eventName))
            {
                RegisteredEvents.Add(eventName);
            }
        }

        public void MarkAttendance(string eventName)
        {
            if (RegisteredEvents.Contains(eventName) && !AttendedEvents.Contains(eventName))
            {
                AttendedEvents.Add(eventName);
            }
        }
    }
}
