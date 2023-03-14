using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CustodianProduct.Application.Attribute
{
	public class ImageFormatValidationAttribute : ValidationAttribute
	{
		public ImageFormatValidationAttribute(string errorMessage) : base(errorMessage)
		{

		}
		public override bool IsValid(object? value)
		{
			if (value != null)
			{
				var image = (IFormFile)value;
				var fileFormats = new string[] { ".jpeg", ".jpg", ".png", ".pdf" };
				var fileExt = image.FileName.ToLower();
				foreach (var item in fileFormats)
				{
					if (fileExt.EndsWith(item))
					{
						return true;
					}
				}
			}
			return false;
		}
	}
}
