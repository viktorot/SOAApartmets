using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibraryV1.Models.Utils;

namespace ApartmentComplexServiceLibraryV1.DAO
{
	class PublicServiceDAO
	{

		public List<Types.apartment> Search(int dateFrom, int dateTo, int numOfBeds)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.apartment> result = entities.apartments.ToList();

				if (numOfBeds != -1)
				{
					result = entities.apartments.Where(ap => ap.no_single_beds + ap.no_king_beds * 2 + ap.no_extra_beds >= numOfBeds).ToList();
				}

				if (dateFrom != -1 && dateTo != -1)
				{
					List<Models.apartment> tmp = entities.apartments.ToList();

					foreach (Models.apartment ap in result)
					{
						if (ap.bookings.Count > 0)
						{
							Models.booking b = ap.bookings.FirstOrDefault(el => el.date_from >= dateFrom || el.date_to <= dateTo);
							if (b == null)
							{
								tmp.Add(ap);
							}
						}
						else
						{
							tmp.Add(ap);
						}
					}

					result = tmp;
				}

				return result.Select(el => ApartmentTypeConverter.ApartmentModelToObj(el)).ToList();
			}
			catch (Exception ex)
			{
				return new List<Types.apartment>();
			}
		}

		public List<Types.apartment> AdvancedSearch(int dateFrom, int dateTo, int numOfKingBeds, int numOfSingleBeds, int numOfExtraBeds,
														bool petFriendly, bool internet, bool airContitioning, bool tv, bool kitchen,
														int stars, bool balcony, bool accessable)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.apartment> result = entities.apartments.ToList();

				// filter by avilability
				if (dateFrom != -1 && dateTo != -1)
				{
					List<Models.apartment> tmp = entities.apartments.ToList();

					foreach (Models.apartment ap in result)
					{
						if (ap.bookings.Count > 0)
						{
							Models.booking b = ap.bookings.FirstOrDefault(el => el.date_from >= dateFrom || el.date_to <= dateTo);
							if (b == null)
							{
								tmp.Add(ap);
							}
						}
						else
						{
							tmp.Add(ap);
						}
					}

					result = tmp;
				}

				if (numOfKingBeds != -1)
				{
					result = result.Where(ap => ap.no_king_beds >= numOfKingBeds).ToList();
				}

				if (numOfSingleBeds != -1)
				{
					result = result.Where(ap => ap.no_single_beds >= numOfSingleBeds).ToList();
				}

				if (numOfExtraBeds != -1)
				{
					result = result.Where(ap => ap.no_extra_beds >= numOfExtraBeds).ToList();
				}

				if (petFriendly)
				{
					result = result.Where(ap => ap.pet_friendly == true).ToList();
				}

				if (petFriendly)
				{
					result = result.Where(ap => ap.pet_friendly == true).ToList();
				}

				if (internet)
				{
					result = result.Where(ap => ap.internet == true).ToList();
				}

				if (airContitioning)
				{
					result = result.Where(ap => ap.air_conditioning == true).ToList();
				}

				if (tv)
				{
					result = result.Where(ap => ap.tv == true).ToList();
				}

				if (kitchen)
				{
					result = result.Where(ap => ap.kitchen == true).ToList();
				}
				
				if (stars != -1)
				{
					result = result.Where(ap => ap.class_stars >= stars).ToList();
				}

				if (balcony)
				{
					result = result.Where(ap => ap.balcony == true).ToList();
				}

				if (accessable)
				{
					result = result.Where(ap => ap.accessible == true).ToList();
				}

				return result.Select(el => ApartmentTypeConverter.ApartmentModelToObj(el)).ToList();
			}
			catch (Exception ex)
			{
				return new List<Types.apartment>();
			}
		}

		public int MakeBooking(int user_trr, int apartmentId, int dateFrom, int dateTo, int package_arrangment_id, string discountCode, bool bank_payment)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.apartment apartmentModel = entities.apartments.FirstOrDefault(el => el.id.Equals(apartmentId));

				if(apartmentModel != null) 
				{
					Models.payment_method method = new Models.payment_method();
					method.bank_payment = bank_payment; // true -> e-bull; false -> card
					method.card_number = user_trr.ToString();

					Models.booking newBooking = new Models.booking();
					newBooking.customer_idcustomer = user_trr;
					newBooking.apartment_idapartment = apartmentId;
					newBooking.date_from = dateFrom;
					newBooking.date_to = dateTo;
					newBooking.payment_method = method;

					if (bank_payment)
					{
						newBooking.status = "pending";
					}
					else
					{
						newBooking.status = "paid";
					}					

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
					return newBooking.id;
				}
				else 
				{
					return -1;
				}

			}
			catch (Exception ex)
			{
				return -1;
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
				return null;
			}
		}

		public Types.booking_description_response[] GetBookingsForUser(string userTrr)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.booking> bookingModelList = entities.bookings.Where(el => el.customer.id.Equals(userTrr)).ToList();
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
				return null;
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
				return null;
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
				return null;
			}
		}

	}
}
