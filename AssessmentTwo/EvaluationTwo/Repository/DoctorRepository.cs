using EvaluationTwo.Common;
using EvaluationTwo.Model;
using EvaluationTwo.Model.Types;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo.Repository
{
    internal class DoctorRepository : IStorage<Doctor>

    {
        private SqlConnection _connection;
        public DoctorRepository()
        {
            _connection = new SqlConnection(AppSettings.ConnectionString);

        }
        public void Add(Doctor doctor)
        {
            EnsureConnectionIsOpen();
            var sql = $"INSERT INTO Doctors(name,specialization,PatientId)VALUES(@name,@specialization,@patientId)";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@name", doctor.Name);
            command.Parameters.AddWithValue("@specialization", doctor.Specialization);
            command.Parameters.AddWithValue("@patientId", doctor.PatientId);
          
            command.ExecuteNonQuery();
            Console.WriteLine("Doctor  Added");
            _connection.Close();
        }

        public void Delete(int id)
        {
            EnsureConnectionIsOpen();
            var sql = $"Delete From Doctors where id = @id";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            Console.WriteLine("Doctor deleted");
            _connection.Close();


        }

        public List<Doctor> GetAll()
        {
            EnsureConnectionIsOpen ();
            var sql = $"Select id,name,specialization,PatientId from Doctors";
            var command = new SqlCommand(sql, _connection);
            var reader = command.ExecuteReader();
            var doctors = new List<Doctor>();
            while (reader.Read())
            {
                string specialString = reader.GetString(2);
                Specialization specialEnum = (Specialization)Enum.Parse(typeof(Specialization), specialString);
                doctors.Add(new Doctor
                {
                    Id = reader.GetInt32(0),
                    Name = reader.GetString(1),
                    Specialization = specialEnum,
                    PatientId = reader.IsDBNull(3) ? (int?)null : reader.GetInt32(3)


                });
            }
            reader.Close();
            return doctors;
            _connection.Close();
        }

        public void Update(Doctor doctor)
        {

            EnsureConnectionIsOpen();
            var sql = $"UPDATE Patients set name =@name, PatientId =@patientId where id = @id";
            var command = new SqlCommand(sql, _connection);
            command.Parameters.AddWithValue("@id", doctor.Id);
            command.Parameters.AddWithValue("@name", doctor.Name);
            command.Parameters.AddWithValue("@patientId",doctor.PatientId?? (Object)DBNull.Value);
            command.ExecuteNonQuery();
            Console.WriteLine("Doctor Updated Successfully");
            _connection.Close();
        }
        private void EnsureConnectionIsOpen()
        {
            if (_connection.State != ConnectionState.Open)
            {
                _connection.Open();
            }
        }
    }
}
