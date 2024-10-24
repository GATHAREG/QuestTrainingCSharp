using EvaluationTwo.Model.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationTwo.Model
{
    internal class Patient

    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age {  get; set; }   

        public  Gender Gender { get; set; }

        public string MedicalCondition {  get; set; }
      
    }
}
