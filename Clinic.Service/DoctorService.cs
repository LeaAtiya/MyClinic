
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clinic;
using Clinic.Core.Services;
//using Clinic.Services;
using Clinic.Entities;

namespace Clinic.Service
{
    public class DoctorService :IDoctorService
    {
        private readonly IDoctorService _doctorService;
        public DoctorService(IDoctorService doctorService) => _doctorService = doctorService;

        public IEnumerable<Doctor> GetDoctors() => _doctorService.GetDoctors();
        public Doctor GetDoctor(int id) => _doctorService.GetDoctor(id);
        public void AddDoctor(Doctor e) => _doctorService.AddDoctor(e);
        public bool UpdateDoctor(int id, Doctor e) => _doctorService.UpdateDoctor(id, e);

        public bool UpdateDoctorStatus(int id, bool status)
        {
            Doctor e = _doctorService.GetDoctor(id);
            if (e != null)
            {
                e.Status = status;
                return true;
            }
            return false;
        }

       

       
    }
}
