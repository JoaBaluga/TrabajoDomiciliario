using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class DoctorsRepositories
    {
        public Doctor GetOlderDoctorWorking()
        {
            using (MyContext context = new MyContext())
            {
                return context.Doctors.Where(d => d.Hospitals.Count > 0).OrderByDescending(d => d.DateOfBirth).FirstOrDefault();
            }
            
        }

        public List<Doctor> GetOlderDoctorsWithSpecialties()
        {
            using (MyContext context = new MyContext())
            {
                return context.Doctors.Where(d => (d.Specialty == Specialties.Pediatrics) || (d.Specialty == Specialties.Fisiatry)).ToList();
            }
        }
    }
}
