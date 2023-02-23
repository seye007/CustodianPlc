using System.ComponentModel.DataAnnotations;

namespace CustodianPlc.Models
{
  public class PersonalInformation
  {
    [Required]
    public string Title { get; set; }
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string SurName { get; set; }
    [Required]
    public string Email { get; set; }
    [Required]
    public string PhoneNumber { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public string Gender { get; set; }
    [Required]
    public string Occupation { get; set; }
    [Required]
    public string State { get; set; }
    [Required]
    public string IdentificationType { get; set; }

    [Required]
    public string IdentificationNumber { get; set; }
    [Required]
    public string Address { get; set; }

  }
}