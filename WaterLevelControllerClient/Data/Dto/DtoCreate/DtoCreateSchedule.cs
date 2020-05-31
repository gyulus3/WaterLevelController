namespace WaterLevelControllerClient.Data.Dto
{
    public class DtoCreateSchedule
    {
        public string Name { get; set; }
        public int MinWaterLevel { get; set; }
        public bool Auto { get; set; }
    }
}
