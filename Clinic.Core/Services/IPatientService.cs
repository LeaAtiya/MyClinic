using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IPatientService
    {
        public IEnumerable<Patient> GetPatients();
        public Patient GetPatient(int id);
        public void AddPatient(Patient Patient);
        public bool UpdatePatient(int id, Patient Patient);
        public bool UpdatePatientStatus(int id, bool status);

    }
}
