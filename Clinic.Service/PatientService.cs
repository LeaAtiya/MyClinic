using Clinic.Core.Services;
using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Service
{
    public class PatientService
    {
        private readonly IPatientService _patientService;
        public PatientService(IPatientService PatientService) => _patientService = PatientService;

        public IEnumerable<Patient> GetPatients() => _patientService.GetPatients();
        public Patient GetPatient(int id) => _patientService.GetPatient(id);
        public void AddPatient(Patient e) => _patientService.AddPatient(e);
        public bool UpdatePatient(int id, Patient e) => _patientService.UpdatePatient(id, e);

        public bool UpdatePatientStatus(int id, bool status)
        {
            Patient e = _patientService.GetPatient(id);
            if (e != null)
            {
                e.Status = status;
                return true;
            }
            return false;
        }




    }
}
