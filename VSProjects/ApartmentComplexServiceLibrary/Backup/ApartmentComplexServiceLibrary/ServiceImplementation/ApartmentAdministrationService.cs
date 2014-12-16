using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.AdministrationService;
using ApartmentComplexServiceLibrary.Types;
using ApartmentComplexServiceLibrary.DAO;

using MySql.Data;

namespace ApartmentComplexServiceLibrary.ServiceImplementation
{
	class ApartmentAdministrationService : IApartmentAdministrationService
	{
		public AddApartmentResponse AddApartment(AddApartmentRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.AddApartment(request.apartment);
            return new AddApartmentResponse(result);
		}

		public FindApartmentResponse FindApartment(FindApartmentRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			apartment result = adminDAO.FindApartment(request.id, request.number_of_beds, request.apartment_number.ToString());
			return new FindApartmentResponse(result);
		}

		public UpdateApartmentResponse UpdateApartment(UpdateApartmentRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateApartment(request.apartment);
            return new UpdateApartmentResponse(result);
		}

		public DeleteApartmentResponse DeleteApartment(DeleteApartmentRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeleteApartment(request.apartment);
            return new DeleteApartmentResponse(result);
		}

		public AddBookingResponse AddBooking(AddBookingRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.AddBooking(request.user_id, request.apartment_id, request.date_from, request.date_to, request.package_arrangment_id, request.discount_code);
            return new AddBookingResponse(result);
		}

		public GetBookingResponse GetBooking(GetBookingRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			booking result = adminDAO.GetBooking(request.id, request.user_id, request.apartment_id, request.date_from, request.date_to);
            return new GetBookingResponse(result);
		}

		public UpdateBookingResponse UpdateBooking(UpdateBookingRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateBooking(request.booking);
            return new UpdateBookingResponse(result);
		}

		public AddPackageArrangementsResponse AddPackageArrangements(AddPackageArrangementsRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.AddPackageArrangments(request.package_arrangements);
            return new AddPackageArrangementsResponse(result);
		}

		public GetPackageArrangementsResponse GetPackageArrangements(GetPackageArrangementsRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			arrangement_package[] result = adminDAO.GetPackageArrangments(request.date_from, request.date_to);
            return new GetPackageArrangementsResponse(result);
		}

		public UpdatePackageArrangementsResponse UpdatePackageArrangements(UpdatePackageArrangementsRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdatePackageArrangements(request.package_arrangements);
			return new UpdatePackageArrangementsResponse(result);
		}

		public DeletePackageArrangementsResponse DeletePackageArrangements(DeletePackageArrangementsRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeletePackageArrangments(request.package_arrangements);
            return new DeletePackageArrangementsResponse(result);
		}

		public AddDiscountResponse AddDiscount(AddDiscountRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.AddDiscount(request.discounts);
            return new AddDiscountResponse(result);
		}

		public UpdateDiscountResponse UpdateDiscount(UpdateDiscountRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateDiscoint(request.discounts);
            return new UpdateDiscountResponse(result);
		}

		public DeleteDiscountResponse DeleteDiscount(DeleteDiscountRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeleteDiscount(request.discounts);
			return new DeleteDiscountResponse(result);
		}

		public UpdateComplexInfoResponse UpdateComplexInfo(UpdateComplexInfoRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateComplexInfo(request.complex);
			return new UpdateComplexInfoResponse(result);
		}

		public AddCustomerResponse AddCustomer(AddCustomerRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.AddCustomer(request.customer);
			return new AddCustomerResponse(result);
		}

		public FindCustomerResponse FindCustomer(FindCustomerRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			customer c = adminDAO.FindCustomer(Convert.ToInt32(request.id), request.first_name, request.last_name, request.tax_number);
            return new FindCustomerResponse(c);
		}

		public UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateCustomer(request.customer);
            return new UpdateCustomerResponse(result);
		}

		public DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeleteCustomer(request.customer);
            return new DeleteCustomerResponse(result);
		}
	}
}
