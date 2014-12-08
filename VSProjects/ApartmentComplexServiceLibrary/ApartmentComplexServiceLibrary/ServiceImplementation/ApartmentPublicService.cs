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
		private void test()
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.payment_method method = new Models.payment_method { card_number = "123123", bank_payment = false };
				entities.payment_method.Add(method);
				entities.SaveChanges();
			}
			catch (Exception ex)
			{
	
			}
		}

		public SearchResponse Search(SearchRequest request)
		{
			apartment ap = new apartment();
			ap.title = "Apartment09";
			test();
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
