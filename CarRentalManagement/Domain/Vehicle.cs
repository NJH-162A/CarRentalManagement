namespace CarRentalManagement.Domain
{
    public class Vehicle : BaseDomainModel
    {
        public int Year { get; set;  }
        public string? LicensePlateNumber { get; set; }
        public int MakeId { get; set; }
        public int Model { get; set; }
        public int Colour { get; set; }
    }
}
