using System;
using diplom.BackEnd.Models.Enums;

namespace diplom.BackEnd.Models
{
    public class Document
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public DocumentType Type { get; set; }
        public string AuthorId { get; set; }
        public string PatientId { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
