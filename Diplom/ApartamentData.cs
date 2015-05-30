namespace Diplom
{
    public class ApartmentData
    {
        [System.ComponentModel.DataAnnotations.Key]
        public int ApartmentDataId {get; set;}
        public string Status { get; set; }
        public string Date { get; set; }
        public string Type { get; set; }
        public string Price { get; set; }
        public int NumRooms { get; set; }
        public int Area { get; set; }
        public int Floor { get; set; }
        public int NumFloor { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Address { get; set; }
        public string Metro { get; set; }
        public string MetroLine { get; set; }
        public string Transport { get; set; }
        public string Comment { get; set; }
    }
}
