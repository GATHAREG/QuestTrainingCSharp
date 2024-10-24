using EvaluationTwo.Model;
using EvaluationTwo.Model.Types;
using EvaluationTwo.Repository;
using EvaluationTwo.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo
{
    internal class PatientManagement
    {
        private readonly IStorage<Patient> _storage;

        public PatientManagement(IStorage<Patient> storageService)
        {
            _storage = storageService;
        }
        public void AddPatient()
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Patient Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter Patient Gender: 1. Male 2.Female 3.Other ");
            var choice = Console.ReadLine();
            Gender gender = Gender.Other;
            
            switch (choice)
            {
                case "1":
                    gender = Gender.Male;
                    break;
                case "2":
                    gender = Gender.Female;
                    break;
                case "3":
                    gender = Gender.Other;
                    break;
                  
            }
            Console.Write("Enter Medical Condition: ");
            string condition = Console.ReadLine();

            var newPatient = new Patient
            {
                Name = name,
                Age = age,
                Gender = gender,
                MedicalCondition = condition
            };

            _storage.Add(newPatient);

           


        }
        public void GetPatient()
        {
           var patients =  _storage.GetAll();
            foreach (var patient in patients)
            {
                Console.WriteLine($"Id: {patient.Id}, Name: {patient.Name}, Age: {patient.Age}, Gender: {patient.Gender}, Medical Condition: {patient.MedicalCondition}");
            }


        }
        public void UpdatePatient()
        {
            Console.Write("Enter Patient ID to update: ");
            int id = int.Parse(Console.ReadLine());

            var patients = _storage.GetAll();
            var patient = patients.FirstOrDefault(p => p.Id == id);
            if(patient != null)
            {
                Console.Write("Enter Patient Name: ");
                patient.Name = Console.ReadLine();
                Console.Write("Enter Patient Age: ");
                patient.Age = int.Parse(Console.ReadLine());
                Console.Write("Enter Medical Condition: ");
                patient.MedicalCondition = Console.ReadLine();
                _storage.Update(patient);
               
            }
            else
            {
                Console.WriteLine("Patient not found");
            }

        }
        public void DeletePatient()
        {
            Console.WriteLine("Enter Patient ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            _storage.Delete(id);


        }
       
        
    }
}
