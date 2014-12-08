using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.PublicService;
using ApartmentComplexServiceLibrary.Types;

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
			return new MakeBookingResponse(booking_response.booked);
		}

		public CancelBookingResponse CancelBooking(CancelBookingRequest request)
		{
			return new CancelBookingResponse(cancel_booking_response.cancelled);
		}

		public GetBookingResponse GetBooking(GetBookingRequest request)
		{
			booking_description_response desc = new booking_description_response();
			return new GetBookingResponse(new booking_description_response[] { desc });
		}

		public GetBookingsForApppartmentResponse GetBookingsForApppartment(GetBookingsForApppartmentRequest request)
		{
			booking_description_response desc = new booking_description_response();
			return new GetBookingsForApppartmentResponse(new booking_description_response[] { desc });
		}

		public GetBookingsForUserResponse GetBookingsForUser(GetBookingsForUserRequest request)
		{
			booking_description_response desc = new booking_description_response();
			return new GetBookingsForUserResponse(new booking_description_response[] { desc });
		}

		public GetPackagesArrangementsResponse GetPackagesArrangements(GetPackagesArrangementsRequest request)
		{
			arrangement_package package = new arrangement_package();
			return new GetPackagesArrangementsResponse(new arrangement_package[] { package });
		}

		public GetDiscountsResponse GetDiscounts(GetDiscountsRequest request)
		{
			discount disc = new discount();
			return new GetDiscountsResponse(new discount[] { disc });
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
