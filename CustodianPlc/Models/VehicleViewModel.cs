using System.ComponentModel.DataAnnotations;

namespace CustodianPlc.Models
{
  public class VehicleViewModel
  {
    [Required]
    public string TypeOfCover { get; set; }
    [Required]
    public string VehicleCategory { get; set; }
    [Required]
    public decimal VehicleValue { get; set; }
    [Required]
    public string PaymentOption { get; set; }
    [Required]
    public string VehicleMake { get; set; }
    [Required]
    public string VehicleModel { get; set; }
    [Required]
    public string RegistrationNumber { get; set; }
    [Required]
    public string ChasisNo { get; set; }
    [Required]
    public string EngineNumber { get; set; }
    [Required]
    public string YearOfMake { get; set; }
    [Required]
    public string CarBodyType { get; set; }
    [Required]
    public DateTime InsuranceStartDate { get; set; }
    [Required]
    public string VehicleColor { get; set; }
    public decimal Total { get; set; }
  }
}
