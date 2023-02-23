namespace CustodianPlc.Models
{
	public class UserSession
	{
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string SurName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Gender { get; set; }
    public string Occupation { get; set; }
    public string State { get; set; }
    public string IdentificationType { get; set; }
    public string IdentificationNumber { get; set; }
    public string Address { get; set; }
    public byte[] UpdateImageBytes { get; set; }
		public string UpdateImageContentType { get; set; }
	}
}
