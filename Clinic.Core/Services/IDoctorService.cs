using Clinic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Core.Services
{
    public interface IDoctorService
    {
        public IEnumerable<Doctor> GetDoctors();
        public Doctor GetDoctor(int id);
        public void AddDoctor(Doctor doctor);
        public bool UpdateDoctor(int id, Doctor doctor);
        public bool UpdateDoctorStatus(int id, bool status);
        
    }
}
