using CustodianPlc.Models;
using CustodianProduct.Application.Interfaces;
using CustodianProduct.Domain;
using CustodianProduct.Infrastructure.Repositories.Interface;
namespace CustodianProduct.Application.Implementations
{
	public class SafetyPlusPlanService : ISafetyPlusPlanService
	{
		private readonly IGenericRepository<SafetyPlusPlan> _safetyPlusPlanRepository;
		public SafetyPlusPlanService(IGenericRepository<SafetyPlusPlan> safetyPlusPlanRepository)
		{
			_safetyPlusPlanRepository = safetyPlusPlanRepository;
		}

		public async Task<bool> CreateSafetyPlusPlanAync(SafetyPlusVm safetyPlusProduct, string consentCookie)
		{
			var safetyPlus = new SafetyPlusPlan()
			{
				Id = Guid.NewGuid(),
				Title = safetyPlusProduct.Title,
				Surname = safetyPlusProduct.Surname,
				FirstName = safetyPlusProduct.FirstName,
				Email = safetyPlusProduct.Email,
				Address = safetyPlusProduct.Address,
				CompanyAddress = safetyPlusProduct.Address,
				DateOfBirth = Convert.ToDateTime(safetyPlusProduct.DateOfBirth),
				State = safetyPlusProduct.State,
				IdentificationNo = safetyPlusProduct.IdentificationNo,
				IdentificationType = safetyPlusProduct.IdentificationType,
				Premium = safetyPlusProduct.Premium,
				TelePhone = safetyPlusProduct.TelePhone,
				PolicyPeriod = safetyPlusProduct.PolicyPeriod,
				Gender = safetyPlusProduct.Gender,
				BeneficairyRelationship = safetyPlusProduct.BeneficairyRelationship,
				BeneficiaryDateOfBirth = safetyPlusProduct.BeneficiaryDateOfBirth,
				BeneficiaryIdentificationNumber = safetyPlusProduct.BeneficiaryIdentificationNumber,
				BeneficiaryGender = safetyPlusProduct.BeneficiaryGender,
				BeneficiaryIdentificationType = safetyPlusProduct.BeneficiaryIdentificationType,
				BeneficiaryName = safetyPlusProduct.BeneficiaryName,
				Units = safetyPlusProduct.Units,
				CompanyName = safetyPlusProduct.CompanyName,
				Occupation = safetyPlusProduct.Occupation,
				StartDate = safetyPlusProduct.StartDate,
				ConsentCookie = consentCookie,
				CreatedAt = DateTime.UtcNow
			};

			using (var identificationImageStream = safetyPlusProduct.BeneficiaryMeansOfIdentification.OpenReadStream())
			{
				BinaryReader binaryReader = new BinaryReader(identificationImageStream);
				safetyPlus.BeneficiaryMeansOfIdentification = binaryReader.ReadBytes((int)identificationImageStream.Length);
			}
			using (var IdUploadFileImageStream = safetyPlusProduct.MeansOfIdentification.OpenReadStream())
			{
				BinaryReader binaryReader = new BinaryReader(IdUploadFileImageStream);
				safetyPlus.MeansOfIdentification = binaryReader.ReadBytes((int)IdUploadFileImageStream.Length);
			}
			return await _safetyPlusPlanRepository.AddAsync(safetyPlus);
		}
	}
}
