using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.AdministrationService;
using ApartmentComplexServiceLibrary.Types;
using ApartmentComplexServiceLibrary.DAO;
using ApartmentComplexServiceLibrary.Faults;

using MySql.Data;
using System.ServiceModel;

namespace ApartmentComplexServiceLibrary.ServiceImplementation
{
	class ApartmentAdministrationService : IApartmentAdministrationService
	{
		private void ThrowNotFoundException()
		{
			NotFoundException ex = new NotFoundException();
			throw new FaultException<NotFoundException>(ex, String.Format("Reason: Item not found."));
		}

		private void ThrowNotFoundException(int id) 
		{
			NotFoundException ex = new NotFoundException();
			ex.ItemId = id.ToString();
			throw new FaultException<NotFoundException>(ex, String.Format("Reason: Item  with ID:{0} not found.", id));
		}

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
			if (result != null)
			{
				return new FindApartmentResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.id);
				return null;
			}
		}

		public UpdateApartmentResponse UpdateApartment(UpdateApartmentRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateApartment(request.apartment);
			if (result)
			{
				return new UpdateApartmentResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.apartment.id);
				return null;
			}
            
		}

		public DeleteApartmentResponse DeleteApartment(DeleteApartmentRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeleteApartment(request.apartment);
			if (result)
			{
				return new DeleteApartmentResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.apartment.id);
				return null;
			}
            
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
			if (result != null)
			{
				return new GetBookingResponse(result);
			}
			else
			{
				ThrowNotFoundException();
				return null;
			} 
            
		}

		public UpdateBookingResponse UpdateBooking(UpdateBookingRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateBooking(request.booking);
			if (result)
			{
				return new UpdateBookingResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.booking.id);
				return null;
			}
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
			if (result)
			{
				return new UpdatePackageArrangementsResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.package_arrangements.id);
				return null;
			}
		}

		public DeletePackageArrangementsResponse DeletePackageArrangements(DeletePackageArrangementsRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeletePackageArrangments(request.package_arrangements);
			if (result)
			{
				return new DeletePackageArrangementsResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.package_arrangements.id);
				return null;
			}
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
			if (result)
			{
				return new UpdateDiscountResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.discounts.id);
				return null;
			}
		}

		public DeleteDiscountResponse DeleteDiscount(DeleteDiscountRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeleteDiscount(request.discounts);
			if (result)
			{
				return new DeleteDiscountResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.discounts.id);
				return null;
			}
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
			if (c != null)
			{
				return new FindCustomerResponse(c);
			}
			else
			{
				ThrowNotFoundException(Convert.ToInt32(request.id));
				return null;
			}
		}

		public UpdateCustomerResponse UpdateCustomer(UpdateCustomerRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.UpdateCustomer(request.customer);
			if (result)
			{
				return new UpdateCustomerResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.customer.id);
				return null;
			}
		}

		public DeleteCustomerResponse DeleteCustomer(DeleteCustomerRequest request)
		{
			AdministrationServiceDAO adminDAO = new AdministrationServiceDAO();
			bool result = adminDAO.DeleteCustomer(request.customer);
			if (result)
			{
				return new DeleteCustomerResponse(result);
			}
			else
			{
				ThrowNotFoundException(request.customer.id);
				return null;
			}
		}
	}
}
