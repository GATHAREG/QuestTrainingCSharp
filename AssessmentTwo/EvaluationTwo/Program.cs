using EvaluationTwo.Repository;
using EvaluationTwo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var patientStorage = new PatientRepository();
            var doctorStorage  = new DoctorRepository();
            var patientManagement = new PatientManagement(patientStorage);
            var doctorManagement = new DoctorMangement(doctorStorage);

            while (true)
            {
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. Add Doctor");
                Console.WriteLine("3. Get All Patients");
                Console.WriteLine("4. Get All Doctors");
                Console.WriteLine("5. Update Patient");
                Console.WriteLine("6. Update Doctor");
                Console.WriteLine("7. Delete Patient");
                Console.WriteLine("8. Delete Doctor");
                Console.WriteLine("9. Exit");

                var option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        patientManagement.AddPatient();
                        break;
                    case "2":
                        doctorManagement.AddDoctor();
                        break;
                    case "3":
                        patientManagement.GetPatient();
                        break;
                    case "4":
                        doctorManagement.GetAllDoctor();
                        break;
                    case "5":
                        patientManagement.UpdatePatient();
                        break;
                    case "6":
                        doctorManagement.UpdateDoctor();
                        break;
                    case "7":
                        patientManagement.DeletePatient();
                        break;
                    case "8":
                        doctorManagement.DeleteDoctor();
                        break;
                    case "9":
                        return; 
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }
    }

}
    
