using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Configuration;
using System.ServiceModel.Web;
using System.Text;

using ApartmentComplexServiceLibraryV1.Types.Rest;

namespace ApartmentComplexServiceLibraryV1.ServiceInterfaces
{
	[ServiceContract]
	public interface IRestService
	{
		[OperationContract]
		[WebInvoke(Method="GET", ResponseFormat=WebMessageFormat.Json, UriTemplate="test")]
		string DoWork();

		[OperationContract]
		[WebInvoke(	Method = "POST", 
					ResponseFormat = WebMessageFormat.Json, 
					RequestFormat = WebMessageFormat.Json, 
					UriTemplate = "/apartment", 
					BodyStyle = WebMessageBodyStyle.Bare)]
		string AddApartment();

		[OperationContract]
		[WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "apartment/{id}")]
		string GetApartment(string id);

		[OperationContract]
		[WebInvoke(	Method = "PUT", UriTemplate = "apartment/{id}",
					ResponseFormat = WebMessageFormat.Json, 
					RequestFormat = WebMessageFormat.Json, 
					BodyStyle = WebMessageBodyStyle.Bare)]
		string UpdateApartment(string id);

		[OperationContract]
		[WebInvoke(Method = "DELETE", ResponseFormat = WebMessageFormat.Json, UriTemplate = "apartment/{id}")]
		string RemoveApartment(string id);
	}
}

