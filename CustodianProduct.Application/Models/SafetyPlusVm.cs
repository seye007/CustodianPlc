using CustodianProduct.Application.Attribute;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CustodianPlc.Models
{
  public class SafetyPlusVm : PersonalVm
  {
   
    [Required(ErrorMessage = "Start date is Required")]
    public DateTime StartDate { get; set; }

    [Required(ErrorMessage = "Policy period is required")]
    public string PolicyPeriod { get; set; }

    [Required(ErrorMessage = "Unit")]
    public int Units { get; set; }

    [Required(ErrorMessage = "Please calculate premium")]
    public decimal Premium { get; set; } = 0.0m;

    [Required(ErrorMessage = "Beneficiary identification type is required")]
    public string BeneficiaryIdentificationType { get; set; }

    [Required(ErrorMessage = "Beneficiary identification number is required")]
    public string BeneficiaryIdentificationNumber { get; set; }

    [Required(ErrorMessage = "Company address is required")]
    public string CompanyAddress { get; set; }

    [Required(ErrorMessage = "Beneficiary name is required")]
    [RegularExpression("[a-zA-Z]{1,25}", ErrorMessage = "First name must be letters only")]
    public string BeneficiaryName { get; set; }

    [Required(ErrorMessage = "Beneficiary date of birth is required")]
    public DateTime BeneficiaryDateOfBirth { get; set; }

    [Required(ErrorMessage = "Beneficiary gender is required")]
    public string BeneficiaryGender { get; set; }

    [Required(ErrorMessage = "Beneficiary Identification Image is required")]
    [ImageSizeValidation(errorMessage: "Image size should not be more than 500KB")]
    [ImageFormatValidation(errorMessage: "File format not supported")]
    public IFormFile BeneficiaryMeansOfIdentification { get; set; }

    [Required(ErrorMessage = "Beneficairy relationship is required")]
    [RegularExpression("[a-zA-Z]{1,25}", ErrorMessage = "First name must be letters only")]
    public string BeneficairyRelationship { get; set; }
  }
}