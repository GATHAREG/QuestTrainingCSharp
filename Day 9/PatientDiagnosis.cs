/*You are tasked with developing a simple patient diagnosis management system for a small medical clinic. The system needs to store patient information and track the symptoms they are diagnosed with.
Requirements:
Store patient information using a structure where each patient has the following details:
A unique identifier.
Their name.
Their age.
A list of symptoms they have reported.
Implement the following functionalities:
AddPatient: A function that adds a new patient’s information to the system.
GetPatient: A function that retrieves the details of a patient based on their unique identifier.
GetPatientsBySymptom: A function that returns the identifiers of all patients who have reported a specific symptom.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalDiagnosis
{
    internal class Program
    {
        //dictionary to store the data
       static Dictionary<int, Dictionary<string, string>> patients = new Dictionary<int, Dictionary<string, string>>();

        static void Main(string[] args)
        {
   
            while (true) 
            {
                Console.WriteLine("WELCOME TO PATIENT DIAGNOSIS MANAGEMENT SYSTEM");
                Console.WriteLine("1.Add Patient");
                Console.WriteLine("2.Get Patient");
                Console.WriteLine("3.Get Patient by Symptom");
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice");
                int choice = int.Parse(Console.ReadLine());
                switch (choice) 
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        GetPatient();
                        break;
                    case 3:
                        GetPatientBySymptom();
                        break;
                    case 4:
                        return;


                }
            }

        }

        public static void GetPatientBySymptom()
        {
            Console.Write("Enter the symptoms: ");
            string  symptoms = Console.ReadLine();
            foreach(var patient in patients)
            {
                var details = patient.Value;
                if (details["Symptoms"].Contains(symptoms))
                {
                    Console.WriteLine($"Patient ID: {patient.Key}");
                }
            }
        }

        public static void GetPatient()
        {
            Console.Write("Enter the id: ");
            int id = int.Parse(Console.ReadLine());
            if (patients.ContainsKey(id))
            {
                Console.WriteLine($"patient id {id}");
                var patient = patients[id];
                Console.WriteLine($"Name: {patient["Name"]}");
                Console.WriteLine($"Age: {patient["Age"]}");
                Console.WriteLine($"Symptoms: {patient["Symptoms"]}");

            }
            else
            {
                Console.WriteLine("id is not found");
            }
        }

        public static void AddPatient()
        {
            Console.Write("Enter the id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the age: ");
            string age = Console.ReadLine();
            Console.Write( "Enter the symptoms as comma separated: ");
            string symptoms = Console.ReadLine() ; 
              
            
            patients.Add(id, new Dictionary<string, string>
            {
                {"Name", name },
                {"Age",age },
                {"Symptoms",symptoms}


            });
            Console.WriteLine("patient added");
            // generate random id

            //var id = Guid.NewGuid().ToString();

        }

    }
}