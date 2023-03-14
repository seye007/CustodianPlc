
using System.ComponentModel.DataAnnotations;

namespace CustodianProduct.Domain
{
	public class EventInsurance
	{
		[Key]
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string CompanyName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string InvolvementDetails { get; set; }
    public string EventType { get; set; }
    public string EventHoldingType { get; set; }
    public string ExpectedGuests { get; set; }
    public string SumInsured { get; set; }
    public DateTime EventDate { get; set; }
    public string EventDuration { get; set; }
    public bool PublicLiability { get; set; }
    public bool ProfessionalIndemnity { get; set; }
    public bool EventEquipment { get; set; }
    public bool EventCancellation { get; set; }
    public bool EmployeeAccidentBenefit { get; set; }
    public string CookieConcent { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime? UpdatedAt { get; set; }
  }
}
