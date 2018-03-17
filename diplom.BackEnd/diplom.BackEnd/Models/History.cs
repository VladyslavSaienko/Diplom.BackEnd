using System.Collections.Generic;

namespace diplom.BackEnd.Models
{
    public class History
    {
        public string Id { get; set; }
        public string PatientId { get; set; }
        public List<HistoryPoint> HistoryPoints { get; set; }
    }
}
