namespace WaterLevelControllerClient.Data.Dto
{
    public class DtoSensorListItemWithZone
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mac { get; set; }
        public string Ip { get; set; }
        public string Data { get; set; }
        public string SwitchName { get; set; }
        public string ScheduleName { get; set; }
        public string ZoneName { get; set; }
    }
}
