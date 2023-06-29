namespace API_Consulta_Facil.Models;

public class Appointment
{
    public int Id { get; set; }
    public string PatientName { get; set; }
    public DateTime Date { get; set; }
    public string DoctorName { get; set; }
}
