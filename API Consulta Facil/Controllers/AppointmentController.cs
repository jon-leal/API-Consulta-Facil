using API_Consulta_Facil.Models;
using Microsoft.AspNetCore.Mvc;

namespace API_Consulta_Facil.Controllers
{
    [ApiController]
    [Route("api/appointments")]
    public class AppointmentController : ControllerBase
    {
        private List<Appointment> _appointments = new List<Appointment>(); // Simulação de um banco de dados em memória

        [HttpGet]
        public ActionResult<List<Appointment>> GetAppointments()
        {
            return _appointments;
        }

        [HttpPost]
        public ActionResult<Appointment> CreateAppointment(CreateAppointmentRequest request)
        {
            var newAppointment = new Appointment
            {
                Id = _appointments.Count + 1,
                PatientName = request.PatientName,
                Date = request.Date,
                DoctorName = request.DoctorName
            };

            _appointments.Add(newAppointment);

            return CreatedAtAction(nameof(GetAppointmentById), new { id = newAppointment.Id }, newAppointment);
        }

        [HttpGet("{id}")]
        public ActionResult<Appointment> GetAppointmentById(int id)
        {
            var appointment = _appointments.FirstOrDefault(a => a.Id == id);
            if (appointment == null)
            {
                return NotFound();
            }

            return appointment;
        }
    }

}
