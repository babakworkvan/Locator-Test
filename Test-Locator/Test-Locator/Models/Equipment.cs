using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Locator.Models
{
    public class Equipment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SerialNo { get; set; }

        public string Uuid { get; set; }

        public EquipType EquipType { get; set; }

        public int EquipTypeId { get; set; }
    }
}