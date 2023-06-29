namespace API_Consulta_Facil.Models
{
    public class CreateAppointmentRequest
    {
        public string PatientName { get; set; }
        public DateTime Date { get; set; }
        public string DoctorName { get; set; }
    }
}
