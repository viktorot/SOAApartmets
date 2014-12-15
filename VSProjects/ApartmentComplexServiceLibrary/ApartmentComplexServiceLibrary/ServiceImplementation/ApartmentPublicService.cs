using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.PublicService;
using ApartmentComplexServiceLibrary.Types;
using ApartmentComplexServiceLibrary.DAO;

namespace ApartmentComplexServiceLibrary.ServiceImplementation
{
	class ApartmentPublicService : IApartmentPublicService
	{
		public SearchResponse Search(SearchRequest request)
		{
			apartment ap = new apartment();
			ap.title = "Apartment09";
			return new SearchResponse(new apartment[] { ap });
		}

		public SearchResponse AdvancedSearch(AdvancedSearchRequest request)
		{
			apartment ap = new apartment();
			return new SearchResponse(new apartment[] { ap });
		}

		public MakeBookingResponse MakeBooking(MakeBookingRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			if (publicDAO.MakeBooking(request.user_id, request.apartment_id, request.date_from, request.date_to, request.package_arrangment_id, request.discount_code))
			{
				return new MakeBookingResponse(booking_response.booked);
			}
			else
			{
				return new MakeBookingResponse(booking_response.failed);
			}
}

		public CancelBookingResponse CancelBooking(CancelBookingRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			if (publicDAO.CancleBooking(request.booking_id))
			{
				return new CancelBookingResponse(cancel_booking_response.cancelled);
			}
			else
			{
				return new CancelBookingResponse(cancel_booking_response.failed);
			}
		}

		public GetBookingResponse GetBooking(GetBookingRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			booking_description_response desc = publicDAO.GetBooking(request.booking_id);
			if (desc != null)
			{
				return new GetBookingResponse(new booking_description_response[] { desc });
			}
			else
			{
				return new GetBookingResponse(new booking_description_response[] { });
			}
		}

		public GetBookingsForApppartmentResponse GetBookingsForApppartment(GetBookingsForApppartmentRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			booking_description_response[] result = publicDAO.GetBookingsForApppartment(request.apartment_id);
			return new GetBookingsForApppartmentResponse(result);
		}

		public GetBookingsForUserResponse GetBookingsForUser(GetBookingsForUserRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			booking_description_response[] result = publicDAO.GetBookingsForApppartment(request.user_id);
			return new GetBookingsForUserResponse(result);
		}

		public GetPackagesArrangementsResponse GetPackagesArrangements(GetPackagesArrangementsRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			arrangement_package[] result = publicDAO.GetPackagesArrangements(request.date_from, request.date_to);
			return new GetPackagesArrangementsResponse(result);
		}

		public GetDiscountsResponse GetDiscounts(GetDiscountsRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			discount[] result = publicDAO.GetDiscounts(request.date_from, request.date_to);
			return new GetDiscountsResponse(result);
		}

		public GetComplexInfoResponse GetComplexInfo(GetComplexInfoRequest request)
		{
			return new GetComplexInfoResponse("description", 123.987, 987.123, new string[] { "img1", "img2" });
		}

		public GetApartmentInfoResponse GetApartmentInfo(GetApartmentInfoRequest request)
		{
			apartment ap = new apartment();
			return new GetApartmentInfoResponse(ap, new string[] { "img1", "img2" });
		}
	}
}
