namespace Doctor.Models
{
    public class DoctorAppointment
    {

        public int Id { get; set; }
        public DateTime AppointmentDate { get; set; }
        public TimeSpan AppointmentTime { get; set; }
        public string PatientName { get; set; }
        public string PatientContact { get; set; }
        public int OurDoctorId { get; set; } // Foreign key to the doctordata model
        public OurDoctor OurDoctor  { get; set; }
    }
}
