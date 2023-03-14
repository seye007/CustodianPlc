using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CustodianProduct.Domain
{
	public class SafetyPlusPlan : PersonalInformation
    {
	  	[Key]
      public Guid Id { get; set; }
      [Required(ErrorMessage = "Start date is Required")]
      public DateTime StartDate { get; set; }

      [Required(ErrorMessage = "Policy period is required")]
      public string PolicyPeriod { get; set; }

      [Required(ErrorMessage = "Unit")]
      public int Units { get; set; }

      [Required(ErrorMessage = "Please calculate premium")]
      [Column(TypeName = "decimal(18,4)")]
      public decimal Premium { get; set; } = 0.0m;

      [Required(ErrorMessage = "Beneficiary identification type is required")]
      public string BeneficiaryIdentificationType { get; set; }

      [Required(ErrorMessage = "Beneficiary identification number is required")]
      public string BeneficiaryIdentificationNumber { get; set; }

      [Required(ErrorMessage = "Company address is required")]
      public string CompanyAddress { get; set; }

      [Required(ErrorMessage = "Beneficiary name is required")]
      public string BeneficiaryName { get; set; }

      [Required(ErrorMessage = "Beneficiary date of birth is required")]
      public DateTime BeneficiaryDateOfBirth { get; set; }

      [Required(ErrorMessage = "Beneficiary gender is required")]
      public string BeneficiaryGender { get; set; }

      [Required(ErrorMessage = "Beneficiary Identification Image is required")]
      public byte[] BeneficiaryMeansOfIdentification { get; set; }

      [Required(ErrorMessage = "Beneficairy relationship is required")]
      public string BeneficairyRelationship { get; set; }
      public string ConsentCookie { get; set; }
      public DateTime CreatedAt { get; set; }
      public DateTime? UpdatedAt { get; set; }
      public bool Status { get; set; }
    }
  }