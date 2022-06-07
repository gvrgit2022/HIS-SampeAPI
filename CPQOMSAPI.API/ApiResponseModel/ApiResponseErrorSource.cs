using SampleAPI.API.ApiResponseModel.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleAPI.API.ApiResponseModel
{
	[JsonApiData]
	public class ApiResponseErrorSource
	{
		[JsonProperty("pointer")]
		public string Pointer { get; set; }
	}
}
