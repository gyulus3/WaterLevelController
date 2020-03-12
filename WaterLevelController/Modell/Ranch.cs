using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Modell
{
    public class Ranch
    {
        [Key]
        public int RanchId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public IList<UserRanch> UserRanch { get; set; }
        public ICollection<Switch> Switches { get; set; }
    }
}
