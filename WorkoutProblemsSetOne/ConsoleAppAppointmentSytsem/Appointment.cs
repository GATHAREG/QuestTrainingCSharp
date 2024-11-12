using System;

namespace ConsoleAppAppointmentSytsem
{
    class Appointment
    {
        public int Id { get; set; }
        public string PatientName { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}
