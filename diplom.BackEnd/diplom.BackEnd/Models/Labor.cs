using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using diplom.BackEnd.Models.Enums;

namespace diplom.BackEnd.Models
{
    public class Labor
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public LaborType Type { get; set; }
        public string HospitalId { get; set; }
        public string CompanyId { get; set; }
        public Address Address { get; set; }

    }
}
