using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic.Core.Repositories;
//using Clinic.Core.Entities;
using Clinic.Data;
using System.Numerics;
using Clinic.Entities;

namespace Clinic.Data.Repositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly DataContext _context;
        public DoctorRepository(DataContext context) => _context = context;
        public IEnumerable<Doctor> GetDoctors() => _context.Doctors;
        public Doctor GetDoctor(int id) => _context.Doctors.Find(e => e.Id == id);

        public void AddDoctor(Doctor e) => _context.Doctors.Add(e);

        public bool UpdateDoctor(int id, Doctor updateDoctors)
        {
            var e = _context.Doctors.Find(e => e.Id == id);
            if (e != null)
            {
                e.Name = updateDoctors.Name;
                e.Status = updateDoctors.Status;

                return true;
            }
            return false;
        }

        public bool UpdateDoctorStatus(int id, bool status)
        {
            var e = _context.Doctors.Find(e => e.Id == id);
            if (e != null)
            {
                e.Status = status;
                return true;
            }
            return false;
        }

        
    }
}
