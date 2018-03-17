using System;
using diplom.BackEnd.Models.Enums;

namespace diplom.BackEnd.Models
{
    public class User
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public UserType Type { get; set; }
        public Address Address { get; set; }
        public string ContactId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}
