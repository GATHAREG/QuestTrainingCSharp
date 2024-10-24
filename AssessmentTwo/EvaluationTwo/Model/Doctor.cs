using EvaluationTwo.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo.Model
{
    internal class Doctor
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Specialization Specialization { get; set; }

        public int?  PatientId {  get; set; }
    }
}
