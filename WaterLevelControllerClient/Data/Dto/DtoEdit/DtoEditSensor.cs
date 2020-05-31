namespace WaterLevelControllerClient.Data.Dto
{
    public class DtoEditSensor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public int ZoneId { get; set; }
        public int SwitchId { get; set; }
        public int ScheduleId { get; set; }
    }
}
