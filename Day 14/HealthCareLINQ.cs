/*You are building a healthcare management system. You have two entities: Patient and Appointment.

Patient: Stores information about patients.
Id: Unique identifier of the patient.
Name: Name of the patient.
Age: Age of the patient.
Gender: Gender of the patient.
MedicalCondition: Primary medical condition of the patient.

Appointment: Stores information about the appointments made by patients.

Id: Unique identifier of the appointment.
PatientId: The ID of the patient who has the appointment.
DoctorName: The name of the doctor for the appointment.
AppointmentDate: Date and time of the appointment.
AppointmentType: Type of appointment (e.g., "Consultation", "Surgery", "Follow-up").

Task:
Using LINQ, write a query to find the following information:

List all the patients (name, age, medical condition) who have an upcoming appointment within the next 7 days.

Group the patients by their MedicalCondition and return the total number of patients in each condition category who have upcoming appointments.

Find the patient(s) with the most appointments in the last 30 days. If there are multiple patients with the same number of appointments, return all of them.

For patients over the age of 60, list the patient names along with their most recent appointment (doctor's name, date, and type of appointment).


*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppHealthCareLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patients = new List<Patient>
            {
                new Patient{Id = 1 , Name = "Gatha", Age = 23, Gender ="Female", MedicalCondition= "Fever"},
                new Patient{Id = 2 ,Name = "Minnu",Age = 50, Gender ="Female",MedicalCondition = "HeadAche" },
                new Patient{Id = 3 ,Name = "Mohan",Age = 70 , Gender = "Male",MedicalCondition ="Fracture" },
                new Patient{Id = 4 , Name = "Aryan",Age = 60,Gender = "Male",MedicalCondition = "Vomiting" }
            };
            patients.Add(new Patient { Id = 5, Name = "Raghav", Age = 60, Gender = "Male", MedicalCondition = "Diarrohea" });
            var appointments = new List<Appointment>
            {
                new Appointment{Id = 1 ,PatientId = 1, DoctorName = "Mathew",AppointmentDate=new DateTime(2024,10,22),AppointmentType ="Consultation" },
                new Appointment{Id = 2 ,PatientId = 2, DoctorName = "Mathew",AppointmentDate=new DateTime(2024,10,23),AppointmentType ="Consultation" },
                new Appointment{Id = 3 ,PatientId = 3, DoctorName = "George",AppointmentDate=new DateTime(2024,11,02),AppointmentType ="Surgery" },
                new Appointment{Id = 4 ,PatientId = 4, DoctorName = "Samuel",AppointmentDate=new DateTime(2024,10,22),AppointmentType ="Consultaion" },
                new Appointment{Id = 5,PatientId = 1, DoctorName = "Mathew",AppointmentDate=new DateTime(2024,10,30),AppointmentType ="Follow- up" }
            };

            //1.
            var ListAllDetails = patients
                .Join(
                 appointments,
                 p => p.Id,
                 a => a.PatientId,
                 (patient, appointment) =>
                 new
                 {
                     patient.Name,
                     patient.Age,
                     patient.MedicalCondition,
                     appointment.AppointmentDate



                 }).Where(x => x.AppointmentDate >= DateTime.Now && x.AppointmentDate <= DateTime.Now.AddDays(7));

            foreach (var detail in ListAllDetails)
            {
                Console.WriteLine($"Name : {detail.Name},Age : {detail.Age},Medical Condition : {detail.MedicalCondition}");
            }

            //2.
            var groupPatients = patients
                .Join(
                 appointments,
                 p => p.Id,
                 a => a.PatientId,
                 (patient, appointment) =>
                 new
                 {
                     patient.Name,
                     patient.MedicalCondition,
                     appointment.AppointmentDate,


                 }).Where(x => x.AppointmentDate >= DateTime.Now).GroupBy(x => x.MedicalCondition);
            foreach (var group in groupPatients)
            {
                Console.WriteLine($"condition: {group.Key} , Count : {group.Count()} ");
            }

            //3.
            var MostAppointments = appointments.
               Where(x=>x.AppointmentDate <=DateTime.Now && x.AppointmentDate  >= DateTime.Now.AddDays(-30)).GroupBy(x => x.PatientId)
               .Select(g => new { PatientId = g.Key, AppointmentCount = g.Count() }) 
                 .OrderByDescending(g => g.AppointmentCount);

            var patientsWithMostAppointments = MostAppointments
                 .Where(g => g.AppointmentCount == MostAppointments.First().AppointmentCount)
                    .Select(g => g.PatientId);

            foreach (var patientId in  patientsWithMostAppointments)
            {
                var patient = patients.FirstOrDefault(p => p.Id == patientId);
                Console.WriteLine($"Name: {patient.Name}, Age: {patient.Age}, Medical Condition: {patient.MedicalCondition}");

            }

            //4.
            var PatientsOverAge = patients
               .Join(
                  appointments,
                 p => p.Id,
                a => a.PatientId,
                (patient, appointment) => new
                {
                    patient.Name,
                    patient.Age,
                    patient.MedicalCondition,
                    appointment.DoctorName,
                    appointment.AppointmentDate,
                    appointment.AppointmentType
                })
               .Where(x => x.Age > 60)  // Filter patients over 60
                  .GroupBy(x => new { x.Name, x.Age, x.MedicalCondition })  // Group by patient details
                 .Select(g => new
                 {
                     Patient = g.Key,
                     MostRecentAppointment = g.OrderByDescending(x => x.AppointmentDate).FirstOrDefault()  // Get the most recent appointment
                 });
            foreach (var patientGroup in PatientsOverAge)
            {
                Console.WriteLine($"Patient Name: {patientGroup.Patient.Name}, Age: {patientGroup.Patient.Age}, Medical Condition: {patientGroup.Patient.MedicalCondition}");
                Console.WriteLine($"Most Recent Appointment - Doctor: {patientGroup.MostRecentAppointment.DoctorName}, Date: {patientGroup.MostRecentAppointment.AppointmentDate}, Type: {patientGroup.MostRecentAppointment.AppointmentType}");
                Console.WriteLine();
            }







        }
    }
}
