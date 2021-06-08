using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_Locator.Models
{
    public class EquipType
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IList<Equipment> Equipments { get; set; }
        
    }
}