using System;
using System.Collections.Generic;
using System.Text;

namespace BahatiERPShared
{
   public class Customer
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string ContactPerson { get; set; }
        public int MyProperty { get; set; }
        public string Territory { get; set; }
        public string Type { get; set; }
        public string Market { get; set; }
        public string Status { get; set; }
        public string Entered { get; set; }
        public string Site { get; set; } // This can be the main office or main
        public string AddressLine1 { get; set; }
        public string City { get; set; }
        public string Province { get; set; }


    }
}
