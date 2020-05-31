
namespace WaterLevelControllerClient.Data.Dto
{
    public class DtoEditSchedule
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MinWaterLevel { get; set; }
        public bool Auto { get; set; }
    }
}
