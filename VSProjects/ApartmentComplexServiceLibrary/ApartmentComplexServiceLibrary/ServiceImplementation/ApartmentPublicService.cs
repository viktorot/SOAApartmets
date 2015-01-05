using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService;
using ApartmentComplexServiceLibraryV1.Types;
using ApartmentComplexServiceLibraryV1.DAO;
using ApartmentComplexServiceLibraryV1.Faults;
using ApartmentComplexServiceLibraryV1.External;
using System.ServiceModel;

namespace ApartmentComplexServiceLibraryV1.ServiceImplementation
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
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			List<apartment> searchResult = publicDAO.Search(request.date_from, request.date_to, request.number_of_beds);
			return new SearchResponse(searchResult.ToArray());
		}

		public SearchResponse AdvancedSearch(AdvancedSearchRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			List<apartment> searchResult = publicDAO.AdvancedSearch(request.date_from, request.date_to, request.no_king_beds, request.no_single_beds, request.no_extra_beds,
																	request.pet_friendly, request.internet, request.air_conditioning, request.tv,
																	request.kitchen, request.class_stars, request.balcony, request.accessible);
			return new SearchResponse(searchResult.ToArray());
		}

		public MakeBookingResponse MakeBooking(MakeBookingRequest request)
		{
			PublicServiceDAO publicDAO = new PublicServiceDAO();
			int itemId = publicDAO.MakeBooking(request.user_trr, request.apartment_id, request.date_from, request.date_to, 
									request.package_arrangment_id, request.discount_code, request.bank_payment);
			if (itemId != -1)
			{
				if (request.package_arrangment_id != 0)
				{
					TaxiAccess.OrderTaxi(StaticData.ComplexInfo.Address, request.num_of_people, DateTime.FromFileTimeUtc(request.date_from));
					AquaParkAccess.ReserveAndPayForEvent(1, request.num_of_people, request.user_trr.ToString());

					if (request.bank_payment)
					{
						BankAccess.PlayEBill(1, request.user_trr, request.pin_number, 12.0d);
					}
					else 
					{
						BankAccess.PayWithCard(request.user_trr, request.pin_number, 12.0d);
					}
				}

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
			booking_description_response[] result = publicDAO.GetBookingsForUser(request.user_trr);
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
