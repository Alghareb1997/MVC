namespace Doctor.Models
{
    public class OurDoctor
    {
        public string FullName { set;get; }
        public int Id {  set; get; }
        public int Age { set; get; }
        public string PhoneNumber { set; get; }
        public string Email { set; get; }
        public string Specialiste { set; get; }
        public string Img { set; get; }
        public ICollection<DoctorAppointment> Appointments { get;} =new List<DoctorAppointment>();



    }
}
