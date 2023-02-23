using CustodianPlc.Models;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json;

namespace CustodianPlc.FilterAttributes
{
	public class PersonalInformationFilter : IActionFilter
	{
		public void OnActionExecuting(ActionExecutingContext context)
		{
			var personal = context.ActionArguments["personal"] as PersonalInformationViewModel;
			if (personal != null && context.ModelState.IsValid)
			{
				var savedSession = context.HttpContext.Session.Get("personalInformation");
				if (savedSession is not null)
				{
					context.HttpContext.Session.Remove("personalInformation");
				}
				else
				{
					var userSession = new UserSession
					{
						Title = personal.Title,
						FirstName = personal.FirstName,
						SurName = personal.SurName,
						Email = personal.Email,
						PhoneNumber = personal.PhoneNumber,
						Address = personal.Address,
						IdentificationType = personal.IdentificationType,
						Occupation = personal.Occupation,
						Gender = personal.Gender,
						IdentificationNumber = personal.IdentificationNumber,
						UpdateImageBytes = new byte[personal.MeansOfIdentification.Length],
						UpdateImageContentType = personal.MeansOfIdentification.ContentType,
						DateOfBirth = personal.DateOfBirth,
						State = personal.State,
					};

					personal.MeansOfIdentification.OpenReadStream().Read(userSession.UpdateImageBytes);

					var userJson = JsonConvert.SerializeObject(userSession);
					context.HttpContext.Session.SetString("personalInformation", userJson);
				}
			}
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
			// Do nothing
		}
	}
}
