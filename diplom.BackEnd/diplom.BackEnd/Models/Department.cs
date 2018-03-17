using System.Collections.Generic;
using diplom.BackEnd.Models.Enums;

namespace diplom.BackEnd.Models
{
    public class Department
    {
        public string Id { get; set; }
        public DepartmentType Type { get; set; }
        public string HospitalId { get; set; }
        public List<string> Doctors { get; set; }
        public string DepartmentInfo { get; set; }
    }
}
