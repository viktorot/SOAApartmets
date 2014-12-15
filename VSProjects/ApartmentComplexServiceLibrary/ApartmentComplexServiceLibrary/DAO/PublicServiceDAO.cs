using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.Models.Utils;

namespace ApartmentComplexServiceLibrary.DAO
{
	class PublicServiceDAO
	{

		public bool MakeBooking(int userId, int apartmentId, int dateFrom, int dateTo, int package_arrangment_id, string discountCode)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = entities.customers.FirstOrDefault(el => el.id.Equals(userId));
				Models.apartment apartmentModel = entities.apartments.FirstOrDefault(el => el.id.Equals(apartmentId));

				if(customerModel != null && apartmentModel != null) 
				{
					Models.booking newBooking = new Models.booking();
					newBooking.customer_idcustomer = userId;
					newBooking.apartment_idapartment = apartmentId;
					newBooking.date_from = dateFrom;
					newBooking.date_to = dateTo;
					newBooking.status = "pending";

					Models.arrangement_package arrangementModel = entities.arrangement_package.FirstOrDefault(el => el.id.Equals(package_arrangment_id));
					Models.discount discountModel = entities.discounts.FirstOrDefault(el => el.code.Equals(discountCode));

					if(arrangementModel != null) 
					{
						newBooking.arrangement_package_id = arrangementModel.id;
					}


					if(discountModel != null)
					{
						newBooking.discounts_id = discountModel.id;
					}

					entities.bookings.Add(newBooking);
					entities.SaveChanges();
					return true;
				}
				else 
				{
					return false;
				}

			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public bool CancleBooking(int bookingId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.booking booking = entities.bookings.FirstOrDefault(el => el.id.Equals(bookingId));
				if (booking != null)
				{
					booking.status = "cancelled";
					entities.Entry(booking).State = System.Data.Entity.EntityState.Modified;
					entities.SaveChanges();
					return true;
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public Types.booking_description_response GetBooking(int bookingId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.booking bookingModel = entities.bookings.FirstOrDefault(el => el.id.Equals(bookingId));
				if (bookingModel != null)
				{
					return PublicTypeConverter.BookingModelToBookingDescriptionResponse(bookingModel);
				}
				else
				{
					return null;
				}
			}
			catch(Exception ex)
			{
				return null;
			}
		}

		public Types.booking_description_response[] GetBookingsForApppartment(int apartmentId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.booking> bookingModelList = entities.bookings.Where(el => el.apartment.id.Equals(apartmentId)).ToList();
				if (bookingModelList != null)
				{
					return bookingModelList.Select(el => PublicTypeConverter.BookingModelToBookingDescriptionResponse(el)).ToArray();
				}
				else
				{
					return new Types.booking_description_response[] {};
				}
			}
			catch (Exception ex)
			{
				return new Types.booking_description_response[] { }; // TODO: exception
			}
		}

		public Types.booking_description_response[] GetBookingsForUser(int userId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.booking> bookingModelList = entities.bookings.Where(el => el.customer.id.Equals(userId)).ToList();
				if (bookingModelList != null)
				{
					return bookingModelList.Select(el => PublicTypeConverter.BookingModelToBookingDescriptionResponse(el)).ToArray();
				}
				else
				{
					return new Types.booking_description_response[] { };
				}
			}
			catch (Exception ex)
			{
				return new Types.booking_description_response[] { }; // TODO: exception
			}
		}

		public Types.arrangement_package[] GetPackagesArrangements(int dateFrom, int dateTo)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.arrangement_package> packagesList = entities.arrangement_package.Where(el => el.valid_from >= dateFrom && el.valid_to <= dateTo).ToList();
				if (packagesList != null)
				{
					return packagesList.Select(el => Models.Utils.ApartmentTypeConverter.ArrangmentModelToObj(el)).ToArray();
				}
				else
				{
					return new Types.arrangement_package[] { };
				}

			}
			catch (Exception ex)
			{
				return new Types.arrangement_package[] { }; // TODO: exception
			}
		}

		public Types.discount[] GetDiscounts(int dateFrom, int dateTo)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.discount> discountsList = entities.discounts.Where(el => el.valid_from >= dateFrom && el.valid_to <= dateTo).ToList();
				if (discountsList != null)
				{
					return discountsList.Select(el => Models.Utils.ApartmentTypeConverter.DiscountModelToObj(el)).ToArray();
				}
				else
				{
					return new Types.discount[] { };
				}

			}
			catch (Exception ex)
			{
				return new Types.discount[] { }; // TODO: exception
			}
		}

	}
}
