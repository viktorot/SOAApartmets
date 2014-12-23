using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.PublicService;
using ApartmentComplexServiceLibrary.Types;
using ApartmentComplexServiceLibrary.DAO;
using ApartmentComplexServiceLibrary.Faults;
using System.ServiceModel;

namespace ApartmentComplexServiceLibrary.ServiceImplementation
{
	class ApartmentPublicService : IApartmentPublicService
	{
		private void ThrowDatabaseAccessException()
		{
			DBAccessException ex = new DBAccessException();
			throw new FaultException<DBAccessException>(ex, "Cannot read/write to the database at the moment");
		}


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
			int itemId = publicDAO.MakeBooking(request.user_id, request.apartment_id, request.date_from, request.date_to, request.package_arrangment_id, request.discount_code);
			if (itemId != -1)
			{
				return new MakeBookingResponse(booking_response.booked, itemId);
			}
			else
			{
				return new MakeBookingResponse(booking_response.failed, itemId);
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
			if (result != null)
			{
				return new GetBookingsForApppartmentResponse(result);
			}
			else
			{
				ThrowDatabaseAccessException();
				return null;
			}
		}

		public GetBookingsForUserResponse GetBookingsForUser(GetBookingsForUserRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			booking_description_response[] result = publicDAO.GetBookingsForUser(request.user_id);
			if (result != null)
			{
				return new GetBookingsForUserResponse(result);
			}
			else
			{
				ThrowDatabaseAccessException();
				return null;
			}
		}

		public GetPackagesArrangementsResponse GetPackagesArrangements(GetPackagesArrangementsRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			arrangement_package[] result = publicDAO.GetPackagesArrangements(request.date_from, request.date_to);
			if (result != null)
			{
				return new GetPackagesArrangementsResponse(result);
			}
			else 
			{
				ThrowDatabaseAccessException();
				return null;
			}
		}

		public GetDiscountsResponse GetDiscounts(GetDiscountsRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			discount[] result = publicDAO.GetDiscounts(request.date_from, request.date_to);
			if (result != null)
			{
				return new GetDiscountsResponse(result);
			}
			else
			{
				ThrowDatabaseAccessException();
				return null;
			}
		}

		public GetComplexInfoResponse GetComplexInfo(GetComplexInfoRequest request)
		{
			return new GetComplexInfoResponse(StaticData.ComplexInfo.Description, 123.987, 987.123, new string[] { "img1", "img2" });
		}

		public GetApartmentInfoResponse GetApartmentInfo(GetApartmentInfoRequest request)
		{
			apartment ap = new apartment();
			return new GetApartmentInfoResponse(ap, new string[] { "img1", "img2" });
		}
	}
}
