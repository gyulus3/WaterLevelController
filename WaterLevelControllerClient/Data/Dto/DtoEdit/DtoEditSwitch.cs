using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WaterLevelControllerClient.Data.Dto
{
    public class DtoEditSwitch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
    }
}
