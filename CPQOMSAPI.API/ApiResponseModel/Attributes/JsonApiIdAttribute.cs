using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.API.ApiResponseModel.Attributes
{
	[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
	public class JsonApiIdAttribute : Attribute
	{

	}
}
