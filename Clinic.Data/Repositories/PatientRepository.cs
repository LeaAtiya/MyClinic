using Clinic.Core.Repositories;
using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Data.Repositories
{
    public class PatientRepository:IPatientRepositpry
    {
        private readonly DataContext _context;
        public PatientRepository(DataContext context) => _context = context;
        public IEnumerable<Patient> GetPatients() => _context.Patients;
        public Patient GetPatient(int id) => _context.Patients.Find(e => e.Id == id);

        public void AddPatient(Patient e) => _context.Patients.Add(e);

        public bool UpdatePatient(int id, Patient updatePatients)
        {
            var e = _context.Patients.Find(e => e.Id == id);
            if (e != null)
            {
                e.Name = updatePatients.Name;
                e.Status = updatePatients.Status;

                return true;
            }
            return false;
        }

        public bool UpdatePatientStatus(int id, bool status)
        {
            var e = _context.Patients.Find(e => e.Id == id);
            if (e != null)
            {
                e.Status = status;
                return true;
            }
            return false;
        }


    }
}

