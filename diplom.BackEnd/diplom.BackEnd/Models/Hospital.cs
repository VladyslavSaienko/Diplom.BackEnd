using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using diplom.BackEnd.Models.Enums;

namespace diplom.BackEnd.Models
{
    public class Hospital
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public LaborType LaborType { get; set; }

    }
}
