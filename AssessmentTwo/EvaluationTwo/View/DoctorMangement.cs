using EvaluationTwo.Model;
using EvaluationTwo.Model.Types;
using EvaluationTwo.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo.View
{
    internal class DoctorMangement
    {
        private readonly IStorage<Doctor> _storage;

        public DoctorMangement(IStorage<Doctor> storageService)
        {
            _storage = storageService;
        }

        public void AddDoctor()
        {
            Console.Write("Enter Doctor Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Doctor Specialization: 1.Cardiology 2.Neurology 3.Physician ");
            var choice = Console.ReadLine();
            Specialization specialization = Specialization.Physician;

            switch (choice)
            {
                case "1":
                    specialization = Specialization.Cardiology;
                    break;
                case "2":
                    specialization = Specialization.Neurology;
                    break;
                case "3":
                    specialization = Specialization.Physician;
                    break;

            }
            Console.Write("Enter Patient ID : ");
            string patientIdInput = Console.ReadLine();
            int? patientId = null;

            if (!string.IsNullOrWhiteSpace(patientIdInput))
            {
                patientId = int.Parse(patientIdInput); 
            }

            var newDoctor = new Doctor()
            {
                Name = name,
                Specialization = specialization,
                PatientId = patientId  
            };

            _storage.Add(newDoctor);

        }
        public void GetAllDoctor()
        {
            var doctors = _storage.GetAll();
            foreach (var doctor in doctors)
            {
                Console.WriteLine($"Id: {doctor.Id}, Name: {doctor.Name}, Specialization: {doctor.Specialization},PatientID: {doctor.PatientId}");
            }
        }

        public void UpdateDoctor()
        {
            Console.Write("Enter Doctor ID to update: ");
            int id = int.Parse(Console.ReadLine());

            var doctors = _storage.GetAll();
            var doctor = doctors.FirstOrDefault(d => d.Id == id);
            if (doctor != null)
            {
                Console.Write("Enter New Doctor Name: ");
                doctor.Name = Console.ReadLine();
                Console.Write("Enter New  Patient ID : ");
                string patientIdInput = Console.ReadLine();
                doctor.PatientId  = null;

                if (!string.IsNullOrWhiteSpace(patientIdInput))
                {
                    doctor.PatientId = int.Parse(patientIdInput);
                }
                _storage.Update(doctor);
            }
            else
            {
                Console.WriteLine("No doctor found");
            }
        }
        public void DeleteDoctor()
        {
            Console.WriteLine("Enter Doctor ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            _storage.Delete(id);

        }
    }
}
