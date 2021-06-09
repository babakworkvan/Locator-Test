using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Locator.Models
{
    public class Printer
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string Model { get; set; }

        public string SerialNo { get; set; }

        public string MacAddress { get; set; }

        public Facility Facility { get; set; }

        public byte? FacilityId { get; set; }
    }
}