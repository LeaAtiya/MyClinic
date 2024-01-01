
using Clinic.Entities;

namespace Clinic.Data
{
    public class DataContext
    {
        public List<Doctor> Doctors { get; set; }
        public List<Patient> Patients { get; set; }
        public List<Turn> Turns { get; set; }
        public DataContext()
        {
            Doctors = new List<Doctor> {
            new Doctor{Id= 1,Name="moshe cohen",Status=true },
            new Doctor{Id= 2,Name="meni",Status=true },
            new Doctor{Id= 3,Name="mansur abu zayad",Status=false},
            new Doctor{Id= 4,Name="muchamad ali",Status=true},
            new Doctor{Id= 5,Name="levi itzchok",Status=true} };

            Patients = new List<Patient> {
            new Patient{Id= 1,Name="moti",Status=true },
            new Patient{Id= 2,Name="yaakov",Status=true },
            new Patient{Id= 3,Name="lali",Status=true},
            new Patient{Id= 4,Name="matilda",Status=false},
            new Patient{Id= 5,Name="levi itzchok",Status=true}
            };
            Turns = new List<Turn>
            {
                new Turn{code=1,date=DateTime.Now},
                new Turn{code=2,date=DateTime.Now},
                new Turn{code=3,date=DateTime.Now},
            };

        }
    }
}
