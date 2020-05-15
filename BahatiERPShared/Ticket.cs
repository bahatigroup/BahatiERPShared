using System;

namespace BahatiERPShared
{
    public class Ticket
    {
        public string TicketId { get; set; }
        public string Priority { get; set; }
        public double Age { get; set; }
        public string Status { get; set; }
        public Customer Company { get; set; }
        public string SummaryDescription { get; set; }
        public Employee Consultant { get; set; }

        public Department Department { get; set; }
        public double HoursWorked { get; set; }
        public string ServiceLevel { get; set; }
        public Customer ContactPerson { get; set; }
        public DateTime LastDate { get; set; }
        public string Source { get; set; }

        public string Site { get; set; }
        public bool CustomerUpdated { get; set; }
    }
}
