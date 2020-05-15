using BahatiERPShared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BahatiERP.Web.Pages
{
    public class TicketListBase : ComponentBase
    {
        public ObservableCollection<Ticket> Tickets { get; set; }

        protected override void  OnInitialized()
        {
            LoadTickets();
            StateHasChanged();
            //return base.OnInitializedAsync();
        }

        private void LoadTickets()
        {


            Tickets = new ObservableCollection<Ticket>
            {
                new Ticket
            {
                TicketId = "Dev001",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad"},
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers"},
                Source = "Emailed",
                CustomerUpdated = true


            },
                new Ticket
            {
                TicketId = "Dev001",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            },
                new Ticket
            {
                TicketId = "Dev002",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            },
                new Ticket
            {
                TicketId = "Dev003",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            },
                 new Ticket
            {
                TicketId = "Dev004",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            },
                 new Ticket
            {
                TicketId = "Dev005",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            },
                 new Ticket
            {
                TicketId = "Dev006",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true

                  },
                 new Ticket
            {
                TicketId = "Dev008",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true,
                Site = "Bahati Main"


            },
                 new Ticket
            {
                TicketId = "Dev009",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            },
                  new Ticket
            {
                TicketId = "Dev0010",
                Priority = "Critical",
                Age = 6.9,
                Status = "Design Assined",
                Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
                SummaryDescription = "Have a blue Screen Of death and printer not working",
                Consultant = new Employee { EmployeeName = "Achmad" },
                HoursWorked = 1.25,
                ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
                ContactPerson = new Customer { ContactPerson = "Ryan Kloppers" },
                Source = "Emailed",
                CustomerUpdated = true


            }

            };
            //Ticket ticket1 = new Ticket
            //{
            //    TicketId = "Dev001",
            //    Priority = "Critical",
            //    Age = 6.9,
            //    Status = "Design Assined",
            //    Company = new Customer { CompanyId = 001, CompanyName = "Testinga" },
            //    SummaryDescription = "Have a blue Screen Of death and printer not working",
            //    Consultant = new Employee { EmployeeName = "Achmad"},
            //    HoursWorked = 1.25,
            //    ServiceLevel = "Responded by: " + DateTime.Now.ToShortDateString(),
            //    ContactPerson = new Customer { ContactPerson = "Ryan Kloppers"},
            //    Source = "Emailed",
            //    CustomerUpdated = true

                
            //};

           
        }
    }
}
