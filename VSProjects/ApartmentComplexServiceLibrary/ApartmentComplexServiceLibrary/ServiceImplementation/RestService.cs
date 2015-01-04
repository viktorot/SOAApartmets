using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Web.Http;
using Newtonsoft.Json;

using ApartmentComplexServiceLibraryV1.ServiceInterfaces;
using ApartmentComplexServiceLibraryV1.Types;
using ApartmentComplexServiceLibraryV1.DAO;

namespace ApartmentComplexServiceLibraryV1.ServiceImplementation
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IRestService" in both code and config file together.
	public class RestService : IRestService
	{

		private class Response
		{
			public string status { get; set; }
		}

		public string DoWork() {
			return "well done Viktor! You are king of the world!";
		}

		private string GetBody() 
		{
			var reader = OperationContext.Current.RequestContext.RequestMessage.GetReaderAtBodyContents();
			if (reader.Read())
				return new string (Encoding.ASCII.GetChars(reader.ReadContentAsBase64()));
			else
				return "";
		}

		public string AddApartment()
		{
			string body = GetBody();
			apartment ap = JsonConvert.DeserializeObject<apartment>(body);
			Response response = new Response();
			if (ap != null)
			{
				AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
				if (adminDAO.AddApartment(ap) != -1)
				{
					response.status = "ok";
				}
				else
				{
					response.status = "failed";
				}
			}
			else
			{
				response.status = "failed";
			}
			return JsonConvert.SerializeObject(response);
		}

		public string GetApartment(string id)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			apartment ap = adminDAO.FindApartment(Convert.ToInt32(id));
			if (ap != null)
			{
				return JsonConvert.SerializeObject(ap);
			}
			else
			{
				Response response = new Response();
				response.status = "not_found";
				return JsonConvert.SerializeObject(response);
			}
		}

		public string UpdateApartment(string id)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();

			string body = GetBody();
			apartment ap = JsonConvert.DeserializeObject<apartment>(body);
			ap.id = Convert.ToInt32(id);

			Response response = new Response();
			if (adminDAO.UpdateApartment(ap))
			{
				response.status = "ok";
			}
			else
			{
				response.status = "failed";
			}
			return JsonConvert.SerializeObject(response);
		}

		public string RemoveApartment(string id)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();

			Response response = new Response();
			if (adminDAO.DeleteApartment(Convert.ToInt32(id)))
			{
				response.status = "ok";
			}
			else
			{
				response.status = "not_found";
			}
			return JsonConvert.SerializeObject(response);
		}
	}
}
