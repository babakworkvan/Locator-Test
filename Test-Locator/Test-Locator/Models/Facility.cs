using System.Collections.Generic;

namespace Test_Locator.Models
{
    public class Facility
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public IList<Printer> Printers { get; set; }
    }
}