using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.AdministrationService;
using ApartmentComplexServiceLibrary.Types;

using MySql.Data;

namespace ApartmentComplexServiceLibrary.ServiceImplementation
{
	class ApartmentAdministrationService : IApartmentAdministrationService
	{
		public AddApartmentResponse AddApartment(AddApartmentRequest request)
		{
            return new AddApartmentResponse(false);
			
		}

		public FindApartmentResponse FindApartment(FindApartmentRequest request)
		{
            apartment ap = new apartment();
            ap.title = "Apartment09";
            return new FindApartmentResponse( ap);
		}

		public UpdateApartmentResponse UpdateApartment(UpdateApartmentRequest request)
		{
            return new UpdateApartmentResponse(false);
		}

		public DeleteApartmentResponse DeleteApartment(DeleteApartmentRequest request)
		{
            return new DeleteApartmentResponse(true);
		}

		public AddBookingResponse AddBooking(AddBookingRequest request)
		{
            return new AddBookingResponse(true);
		}

		public GetBookingResponse GetBooking(GetBookingRequest request)
		{
            booking b = new booking();
            b.id=3;
            b.payment = new payment_method();
            b.status= booking_status.completed ;
            b.date_to = 65156415;

            return new GetBookingResponse(b);
		}

		public UpdateBookingResponse UpdateBooking(UpdateBookingRequest request)
		{
            return new UpdateBookingResponse(true);
		}

		public AddPackageArrangementsResponse AddPackageArrangements(AddPackageArrangementsRequest request)
		{
            return new AddPackageArrangementsResponse(false);
		}

		public GetPackageArrangementsResponse GetPackageArrangements(GetPackageArrangementsRequest request)
		{
            arrangement_package package = new arrangement_package();
            return new GetPackageArrangementsResponse(new arrangement_package[] { package });
		}

		public UpdatePackageArrangementsResponse UpdatePackageArrangements(UpdatePackageArrangementsRequest request)
		{
            return new UpdatePackageArrangementsResponse(false);
		}

		public DeletePackageArrangementsResponse DeletePackageArrangements(DeletePackageArrangementsRequest request)
		{
            return new DeletePackageArrangementsResponse(true);
		}

		public AddDiscountResponse AddDiscount(AddDiscountRequest request)
		{
            return new AddDiscountResponse(true);
		}

		public UpdateDiscountResponse UpdateDiscount(UpdateDiscountRequest request)
		{
            return new UpdateDiscountResponse(true);
		}

		public DeleteDiscountResponse DeleteDiscount(DeleteDiscountRequest request)
		{
            return new DeleteDiscountResponse(false);
		}

		public UpdateComplexInfoResponse UpdateComplexInfo(UpdateComplexInfoRequest request)
		{
            return new UpdateComplexInfoResponse(true);
		}

		public AddCustomerResponse AddCustomer(AddCustomerRequest request)
		{
            return new AddCustomerResponse(true);
		}

		public FindCustomerResponse FindCustomer(FindCustomerRequest request)
		{
            customer c = new customer();
            c.first_name = "Pero";
            c.last_name = "Deformero";
            c.email = "horror@bishke.com";
            return new FindCustomerResponse(c);
		}

		public UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest request)
		{
            return new UpdateCustomerResponse(true);
		}

		public DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest request)
		{
            return new DeleteCustomerResponse(true);
		}
	}
}
