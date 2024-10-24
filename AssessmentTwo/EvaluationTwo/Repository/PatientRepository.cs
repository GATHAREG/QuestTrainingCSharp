using EvaluationTwo.Common;
using EvaluationTwo.Model;
using EvaluationTwo.Model.Types;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo.Repository
{
    internal class PatientRepository : IStorage<Patient>
    {
        private SqlConnection _connection;
        public PatientRepository()
        {
            _connection = new SqlConnection(AppSettings.ConnectionString);

        }

        public void Add(Patient patient)
        {
            EnsureConnectionIsOpen();
            var sql = $"INSERT INTO Patients(name,age,gender,medicalCondition)VALUES(@name,@age,@gender,@medicalCondition)";
            var command = new SqlCommand(sql,_connection);
            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@age", patient.Age);
            command.Parameters.AddWithValue("@gender", patient.Gender);
            command.Parameters.AddWithValue("@medicalCondition", patient.MedicalCondition);
            command.ExecuteNonQuery();
            Console.WriteLine("Patient Added");

            _connection.Close();

        }

        public void Delete(int id)
        {
            EnsureConnectionIsOpen ();
            var sql = $"Delete From Patients where id = @id";
            var command = new SqlCommand(sql,_connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery ();
            Console.WriteLine("patient deleted");

            _connection.Close();
           
        }

        public List<Patient> GetAll()
        {
            EnsureConnectionIsOpen ();
            var sql = $"Select id,name,age,gender,medicalCondition from Patients";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            var patients = new List<Patient>();
            while(reader.Read())
            {
                string genderString = reader.GetString(3);
                Gender GenderEnum = (Gender)Enum.Parse(typeof(Gender),genderString);
                patients.Add(new Patient
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Age = reader.GetInt32(2),
                    Gender = GenderEnum,
                    MedicalCondition = reader.GetString(4),
                  

                });
            }
            reader.Close();
            return patients;
            _connection.Close();
        }

        public void Update(Patient patient)
        {
            EnsureConnectionIsOpen();
            var sql = $"UPDATE Patients set name =@name, age =@age,medicalCondition = @medicalCondition where id = @id";
            var command = new SqlCommand(sql , _connection);
            command.Parameters.AddWithValue("@id", patient.Id);
            command.Parameters.AddWithValue("@name", patient.Name);
            command.Parameters.AddWithValue("@age", patient.Age);
            command.Parameters.AddWithValue("@medicalCondition", patient.MedicalCondition);
            command.ExecuteNonQuery();
            Console.WriteLine("Patient Updated Successfully");

            _connection.Close();

        }

        private void EnsureConnectionIsOpen()
        {
            if(_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }

    }
}
