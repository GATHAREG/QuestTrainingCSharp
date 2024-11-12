using System;
using System.Collections.Generic;

namespace ConsoleAppAppointmentSytsem
{
    class AppointmentManager
    {
        private readonly List<Appointment> _appointments = new List<Appointment>();
        private readonly TimeSpan _workingStart = new TimeSpan(9, 0, 0);  
        private readonly TimeSpan _workingEnd = new TimeSpan(17, 0, 0);

        public bool BookAppointment(string patientName, DateTime startTime, DateTime endTime)
        {
            var appointments = new Appointment();
            if(startTime.TimeOfDay< _workingStart || endTime.TimeOfDay > _workingEnd)
            {
                Console.WriteLine("Appointment can only be book between 9Am to 5Pm(17:00)");
                return false;
            }
            if (!IsTimeSlotAvailable(startTime,endTime))
            {
                Console.WriteLine("Appointment time slot not available. Its overlapped");
                return false;
            }
            var appointment = new Appointment
            {
                PatientName = patientName,
                StartTime = startTime,
                EndTime = endTime,
            };
            _appointments.Add(appointment);
            Console.WriteLine("Appointed booked!!");
            return true;

        }
        public List<Appointment> GetAppointments()
        {
           return _appointments;
        }
        public bool IsTimeSlotAvailable(DateTime startTime, DateTime endTime)
        {
            foreach(var appointment in _appointments)
            {
                if (startTime < appointment.EndTime && endTime > appointment.StartTime)
                {
                    return false;
                }
            }
            return true;

        }
        public void Run()
        {
            try
            {


                while (true)
                {
                    Console.WriteLine("Doctor Appointment System");
                    Console.WriteLine("1. Book an Appointment");
                    Console.WriteLine("2. View All Appointments");
                    Console.WriteLine("3. Exit");
                    Console.Write("Choose an option: ");
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the name of patient:");
                            string patientName = Console.ReadLine();
                            Console.Write("Enter appointment start time (dd-mm-yyyy hh:mm): ");
                            DateTime startTime = DateTime.Parse(Console.ReadLine());

                            Console.Write("Enter appointment end time (dd-mm-yyyy hh:mm): ");
                            DateTime endTime = DateTime.Parse(Console.ReadLine());
                            BookAppointment(patientName, startTime, endTime);
                            break;
                        case 2:
                            var appointments = GetAppointments();
                            foreach (var appointment in appointments)
                            {
                                Console.WriteLine($"Name :{appointment.PatientName}, StartTime: {appointment.StartTime} ,EndTime: {appointment.EndTime}");
                            }
                            break;
                        case 3:
                            Console.WriteLine("Exiting");
                            return;
                        default:
                            Console.WriteLine("Invalid choice! try again");
                            break;
                    }

                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
