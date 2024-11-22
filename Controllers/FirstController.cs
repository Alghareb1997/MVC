using Doctor.Data;
using Doctor.Models;
using Microsoft.AspNetCore.Mvc;

namespace Doctor.Controllers
{
    public class FirstController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public IActionResult Index()
        {
            var Doctors = _context.Doctors.ToList();
            return View(model: Doctors);
        }
        public IActionResult Doctor(int id)
        {
            var Doctor1 = _context.Doctors.Find(id);
            return View(Doctor1);
        }
        public IActionResult LINK()
        {

            return View();
        }
        public IActionResult Appoit()
        {
            return View();
        }
        public IActionResult NewAppoit(DoctorAppointment appointment)
        {
            _context.Appointments.Add(new()
            {
                PatientName = appointment.PatientName,
                PatientContact=appointment.PatientContact,
                AppointmentDate=appointment.AppointmentDate,

            });
              _context.SaveChanges();
             return View(Appoit);
         

           
        }
    }
}
