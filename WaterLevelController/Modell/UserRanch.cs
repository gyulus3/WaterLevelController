using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelController.Modell
{
    public class UserRanch
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int RanchId { get; set; }
        public Ranch Ranch { get; set; }
    }
}
