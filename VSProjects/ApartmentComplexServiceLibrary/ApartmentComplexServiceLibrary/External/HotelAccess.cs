using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibraryV1.External
{
	class HotelAccess
	{

		private static Types.hotel_service MapData(string type, string info)
		{
			Types.hotel_service service = new Types.hotel_service();
			service.type = type;
			service.info = info;

			return service;
		}

		public static Types.hotel_service[] GetHotelServices()
		{
			Hotel.HotelServiceClient client = new Hotel.HotelServiceClient();
			Hotel.Storitev[] services = client.PregledStoritev();

			return services.Select(el => MapData(el.NazivStoritve, el.OpisStoritve)).ToArray();
		}

	}
}
