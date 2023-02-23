using CustodianPlc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json;

namespace CustodianPlc.FilterAttributes
{
	public class GetPersonalInformationFilter : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			var result = context.HttpContext.Session.GetString("personalInformation");
			if (result != null)
			{
				var userSession = JsonConvert.DeserializeObject<UserSession>(result);
				var personal = new PersonalInformationViewModel
				{
					Title = userSession.Title,
					FirstName = userSession.FirstName,
					SurName = userSession.SurName,
					Email = userSession.Email,
					PhoneNumber = userSession.PhoneNumber,
					Address = userSession.Address,
					IdentificationType = userSession.IdentificationType,
					Occupation = userSession.Occupation,
					Gender = userSession.Gender,
					IdentificationNumber = userSession.IdentificationNumber,
					DateOfBirth = userSession.DateOfBirth,
					State = userSession.State,
				};

				context.Result = new ViewResult
				{
					ViewName = "PersonalInformation",
					ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary())
					{
						Model = personal
					}
				};
			}
		}
	}
}