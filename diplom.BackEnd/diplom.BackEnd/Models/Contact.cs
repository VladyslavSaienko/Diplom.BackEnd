using System.Collections.Generic;

namespace diplom.BackEnd.Models
{
    public class Contact
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public string HospitalId { get; set; }
        public string DoctorId { get; set; }
        public List<string> FamilyMemberIds { get; set; }
    }
}
