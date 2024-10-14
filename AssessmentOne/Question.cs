/*2. Patient Record System

Scenario:

Create a Patient Record System in C# that manages patient details, updates, and searches.

 
Requirements:

 
Implement functionality to manage:

Patient Details: Store the basic information for each patient, including Name, Age, Diagnosis, and Admission Status (whether the patient is admitted or discharged).

Search and Update: Search for a patient by name and display their details. Allow updating the patient’s diagnosis and admission status.

Functionality:

 
Add new patient records, including their details (Name, Age, Diagnosis, and Admission Status).

Search for a patient by name and display their details (if found).

Update a patient’s diagnosis or admission status (e.g., mark them as discharged).

List all patients currently admitted to the system.

Operations:

 
Adding and storing patient records.

Searching for and updating patient details.

Displaying patient information based on the search or specific criteria (e.g., all admitted patients).*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ExamCSharpBasics
{
    internal class Program
    {
        // dictionary to store the details of patients

       static Dictionary<string,Dictionary<string,object>> patients = new Dictionary<string,Dictionary<string, object>>();
        static void Main(string[] args)
        {  
            while(true)
            {
                Console.WriteLine("Welcome to Patient Record System");
                Console.WriteLine("1.Add patient record");
                Console.WriteLine("2.Search and Update patient record");
                Console.WriteLine("3.List all patients currently admitted");
                Console.WriteLine("4.Exit");
                Console.Write("Enter the choice: ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        AddPatient();
                        break;
                    case 2:
                        SearchUpdate();
                        break;
                    case 3:
                        DisplayAll();
                        break;
                    case 4:
                        return;
                    default:
                        break;

                }
            }
            
        }
        
        // Function to display the admitted one.
        public static void DisplayAll()
        {
            Console.WriteLine("Displaying all admitted patient  details");
            foreach(var patient in patients)
            {
                var item = patient.Value;
                string input = item["Status"].ToString().ToLower();
                if (input == "admitted")
                {
                    Console.WriteLine($"patient name : {patient.Key},  age :{item["Age"]}, Diagnosis: {item["Diagnosis"]}");

                }
                Console.WriteLine();
            }
        }

        // Function to search and update.
        public static void SearchUpdate()
        {
            Console.Write("Enter the name of patient you want to search for: ");
            string name = Console.ReadLine();
            if (patients.ContainsKey(name))
            {
                var patient = patients[name];
                Console.WriteLine($"patient name:{name}, age :{patient["Age"]}, Diagnosis: {patient["Diagnosis"]}, Admission status:{patient["Status"]}");

                Console.WriteLine();
                Console.Write("Do you want any updation(yes/no): ");
                string choice = Console.ReadLine().Trim().ToLower();

                if (choice== "yes")
                {
                    Console.WriteLine("The options to update are:");
                    Console.WriteLine("1.The diagnosis:");
                    Console.WriteLine("2.The admission status(To make discharged/admitted):");

                    Console.Write("Enter the option(1/2): ");
                    int subchoice = int.Parse(Console.ReadLine());
                    switch (subchoice)
                    {
                        case 1:
                            Console.Write("Enter the new diagnosis report: ");
                            string diagnosis = Console.ReadLine();

                            patients[name]["Diagnosis"] = diagnosis;
                            Console.WriteLine("Diagnosis updated");
                            Console.WriteLine();
                            break;
                        case 2:
                            Console.Write("Enter the admission status(admitted/discharged): ");
                            string status = Console.ReadLine().Trim().ToLower();

                            patients[name]["Status"] = status;
                            Console.WriteLine(" Status updated");
                            Console.WriteLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("There is no updation!!!");
                }    
            }
            else
            {
                Console.WriteLine("No patient found!!");
            }
        }

        // Function to add patient details.
        public static void AddPatient()
        {
            while (true)
            {
                Console.WriteLine("Enter the patient details");
                Console.Write("Enter the Name: ");
                string name = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(name))
                {
                    Console.WriteLine("Enter again!");
                    continue;
                }
                

                Console.Write("Enter the age: ");
                int age;
                if(!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Enter a valid age!");
                    continue;

                }


                Console.Write("Enter the diagnosis: ");
                string diagnosis = Console.ReadLine();

                Console.Write("Enter the admission status:(admitted/discharged):");
                string status = Console.ReadLine().Trim().ToLower();


                patients.Add(name, new Dictionary<string, object>{

                {"Age",age },
                {"Diagnosis",diagnosis},
                {"Status",status }

                 });

                Console.WriteLine("Patient Added successfully");
                Console.WriteLine();
                break;
            }
            
        }
    }
}
