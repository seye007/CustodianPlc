using System.ComponentModel.DataAnnotations;

namespace CustodianPlc.Models
{
  public class VehicleDetails
  {
    [Required]
    public byte TypeOfCover { get; set; }
    [Required]
    public byte VehicleCategory { get; set; }
    [Required]
    public decimal VehicleValue { get; set; }
    [Required]
    public byte PaymentOption { get; set; }
    [Required]
    public string VehicleMake { get; set; }
    [Required]
    public string VehicleModel { get; set; }
    [Required]
    public int RegistrationNumber { get; set; }
    [Required]
    public int ChasisNo { get; set; }
    [Required]
    public int EngineNumber { get; set; }
    [Required]
    public int YearOfMake { get; set; }
    [Required]
    public byte CarBodyType { get; set; }
    [Required]
    public DateTime InsuranceStartDate { get; set; }
    [Required]
    public int VehicleColor { get; set; }
    [Required]
    public int Total { get; set; }
  }
}
