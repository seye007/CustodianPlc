using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CustodianPlc.Models
{
  public abstract class PersonalVm
  {
    [Required(ErrorMessage = "Please Select a title")]
    public string Title { get; set; }
    [Required(ErrorMessage = "First name is required")]
    [RegularExpression("[a-zA-Z]{1,25}", ErrorMessage = "First name must be letters only")]
    public string FirstName { get; set; }
    [Required(ErrorMessage = "Surname is required")]
    [RegularExpression("[a-zA-Z]{1,25}", ErrorMessage = "Surname must be letters only")]
    public string Surname { get; set; }
    [RegularExpression("[a-zA-Z&\t ]{1,25}", ErrorMessage = "Company name must be letters and spaces only")]
    [Required(ErrorMessage = "Company name is required")]
    public string CompanyName { get; set; }
    [Required(ErrorMessage = "Email is required")]
    [EmailAddress(ErrorMessage = "Email is not valid")]
    public string Email { get; set; }
    [Required(ErrorMessage = "Gender is required")]
    public string Gender { get; set; }
    [Required(ErrorMessage = "Mobile No is required")]
    public string TelePhone { get; set; }
    [Required(ErrorMessage = "Date of birth is required")]
    public string DateOfBirth { get; set; }
    [Required(ErrorMessage = "Address is required")]
    public string Address { get; set; }
    [Required(ErrorMessage = "State is required")]
    public string State { get; set; }
    [Required(ErrorMessage = "Occupation is required")]
    public string Occupation { get; set; }
    [Required(ErrorMessage = "Identification type is required")]
    public string IdentificationType { get; set; }
    [Required(ErrorMessage = "Identification Number is required")]
    public string IdentificationNo { get; set; }
    [Required(ErrorMessage = "Means identification is required")]
    public IFormFile MeansOfIdentification { get; set; }
  }
}