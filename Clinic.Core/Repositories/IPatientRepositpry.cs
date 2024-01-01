using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Repositories
{
    public interface IPatientRepositpry
    {
        public IEnumerable<Patient> GetPatients();
        public Patient GetPatient(int id);
        public void AddPatient(Patient patient);
        public bool UpdatePatient(int id, Patient patient);
        public bool UpdatePatientStatus(int id, bool status);
    }
}
