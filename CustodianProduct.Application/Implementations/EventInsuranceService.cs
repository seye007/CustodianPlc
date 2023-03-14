using CustodianPlc.Models;
using CustodianProduct.Application.Interfaces;
using CustodianProduct.Domain;
using CustodianProduct.Infrastructure.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustodianProduct.Application.Implementations
{
	public class EventInsuranceService : IEventInsuranceService
	{
		private readonly IGenericRepository<EventInsurance> _eventInsuranceRepository;
		public EventInsuranceService(IGenericRepository<EventInsurance> eventInsurance)
		{
			_eventInsuranceRepository = eventInsurance;
		}

		public async Task<bool> CreateEventInsuranceAsync(EventInsuranceVm eventInsuranceVm, string cookieConsent)
		{
			var eventInsurance = new EventInsurance()
			{
				Id = Guid.NewGuid(),
				Surname = eventInsuranceVm.LastName,
				FirstName = eventInsuranceVm.FirstName,
				CompanyName = eventInsuranceVm.CompanyName,
				Email = eventInsuranceVm.Email,
				PhoneNumber = eventInsuranceVm.PhoneNumber,
				InvolvementDetails = eventInsuranceVm.InvolvementDetails,
				EventType = eventInsuranceVm.EventType,
				EventHoldingType = eventInsuranceVm.EventHoldingType,
				EmployeeAccidentBenefit = eventInsuranceVm.EmployeeAccidentBenefit,
				CookieConcent = cookieConsent,
				EventCancellation = eventInsuranceVm.EventCancellation,
				EventDate = eventInsuranceVm.EventDate,
				EventDuration = eventInsuranceVm.EventDuration,
				EventEquipment = eventInsuranceVm.EventEquipment,
				ExpectedGuests = eventInsuranceVm.ExpectedGuests,
				ProfessionalIndemnity = eventInsuranceVm.ProfessionalIndemnity,
				PublicLiability = eventInsuranceVm.PublicLiability,
				SumInsured = eventInsuranceVm.SumInsured,
				CreatedAt = DateTime.UtcNow
			};


			return await _eventInsuranceRepository.AddAsync(eventInsurance);
		}
	}
}
