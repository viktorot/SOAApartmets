using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService;
using ApartmentComplexServiceLibraryV1.Types;
using ApartmentComplexServiceLibraryV1.Models.Utils;

namespace ApartmentComplexServiceLibraryV1.DAO
{
	class AdministrationServiceDAO
	{
		public int AddApartment(apartment apartmentObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.apartment apartmentModel = new Models.apartment
				{
					accessible = apartmentObj.accessible,
					air_conditioning = apartmentObj.air_conditioning,
					class_stars = apartmentObj.class_stars,
					description = apartmentObj.description,
					latitude = (float?) apartmentObj.latitude,
					longitude = (float?) apartmentObj.longitude,
					no_extra_beds = apartmentObj.no_extra_beds,
					no_single_beds = apartmentObj.no_single_beds,
					no_king_beds = apartmentObj.no_king_beds,
					tv = apartmentObj.tv,
					title = apartmentObj.title,
					pet_friendly = apartmentObj.pet_friendly,
					internet = apartmentObj.internet,
					kitchen = apartmentObj.kitchen
				};
				entities.apartments.Add(apartmentModel);
				entities.SaveChanges();

				return apartmentModel.id;
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public apartment[] FindApartment(int id, int num_of_beds)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.apartment> apartmentModels = new List<Models.apartment>();

				if (id == 0 && num_of_beds == 0)
				{
					apartmentModels = entities.apartments.ToList();
				}
				else if (id > 0)
				{
					apartmentModels = entities.apartments.Where(el => el.id.Equals(id)).ToList();
				}
				else
				{
					apartmentModels = entities.apartments.Where(el => el.no_extra_beds + el.no_king_beds * 2 + el.no_single_beds >= num_of_beds).ToList();
				}				

				if (apartmentModels != null)
				{
					return apartmentModels.Select(el => Models.Utils.ApartmentTypeConverter.ApartmentModelToObj(el)).ToArray();
				}
				else
				{
					return null;
				}
				
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool UpdateApartment(apartment apartmentObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.apartment apartmentModel = entities.apartments.FirstOrDefault(el => el.id.Equals(apartmentObj.id));

				if(apartmentModel != null) 
				{
					apartmentModel.accessible = apartmentObj.accessible;
					apartmentModel.air_conditioning = apartmentObj.air_conditioning;
					apartmentModel.class_stars = apartmentObj.class_stars;
					apartmentModel.description = apartmentObj.description;
					apartmentModel.latitude = (float?)apartmentObj.latitude;
					apartmentModel.longitude = (float?)apartmentObj.longitude;
					apartmentModel.no_extra_beds = apartmentObj.no_extra_beds;
					apartmentModel.no_single_beds = apartmentObj.no_single_beds;
					apartmentModel.no_king_beds = apartmentObj.no_king_beds;
					apartmentModel.tv = apartmentObj.tv;
					apartmentModel.title = apartmentObj.title;
					apartmentModel.pet_friendly = apartmentObj.pet_friendly;
					apartmentModel.internet = apartmentObj.internet;
					apartmentModel.kitchen = apartmentObj.kitchen;

					entities.Entry(apartmentModel).State = System.Data.Entity.EntityState.Modified;
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

		public bool DeleteApartment(int apartmentId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.apartment apartmentModel = entities.apartments.FirstOrDefault(el => el.id.Equals(apartmentId));

				if (apartmentModel != null)
				{
					entities.Entry(apartmentModel).State = System.Data.Entity.EntityState.Deleted;
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

		public int AddBooking(int user_trr, int apartmentId, int dateFrom, int dateTo, int packagArrangementId, string discountCode)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = entities.discounts.FirstOrDefault(el => el.code.Equals(discountCode));
				
				Models.booking bookingModel = new Models.booking
				{
					customer_idcustomer = user_trr,
					date_from = dateFrom,
					date_to = dateTo,
					arrangement_package_id = packagArrangementId,
					discounts_id = discountModel != null ? discountModel.id : -1
				};
				return bookingModel.id;
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public booking GetBooking(int id, int userId, int apartmentId, int dateFrom, int dateTo)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.booking bookingModel = entities.bookings.FirstOrDefault(el => el.id.Equals(id) || el.customer.id.Equals(userId) || el.apartment.id.Equals(apartmentId) || 
												(el.date_from >= dateFrom && el.date_to <= dateTo));
				if (bookingModel != null)
				{
					booking bookingObj = new booking
					{
						id = bookingModel.id,
						date_from = bookingModel.date_from,
						date_to = bookingModel.date_to,
						//customer = ApartmentTypeConverter.CustomerModelToObj(bookingModel.customer),
						apartment = ApartmentTypeConverter.ApartmentModelToObj(bookingModel.apartment),
						status = ApartmentTypeConverter.BookingStatusStringToEnum(bookingModel.status),
						discount = ApartmentTypeConverter.DiscountModelToObj(bookingModel.discount),
						payment = ApartmentTypeConverter.PaymentModelToObj(bookingModel.payment_method)
					};
					return bookingObj;
				}
				else
				{
					return null;
				}
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool UpdateBooking(booking bookingObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.booking bookingModel = entities.bookings.FirstOrDefault(el => el.id.Equals(bookingObj.id));
				if (bookingModel != null)
				{
					bookingModel.id = bookingObj.id;
					bookingModel.date_from = bookingObj.date_from;
					bookingModel.date_to = bookingObj.date_to;
					bookingModel.status = bookingObj.status.ToString();
					bookingModel.apartment = ApartmentTypeConverter.ApartmentObjToModel(bookingObj.apartment);
					//bookingModel.customer = ApartmentTypeConverter.CustomerObjToModel(bookingObj.customer);
					bookingModel.payment_method = ApartmentTypeConverter.PaymentObjToModel(bookingObj.payment);
					bookingModel.discount = ApartmentTypeConverter.DiscountObjToModel(bookingObj.discount);

					entities.Entry(bookingModel).State = System.Data.Entity.EntityState.Modified;
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

		public int AddPackageArrangments(arrangement_package arrangmentObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.arrangement_package arrangmentModel = ApartmentTypeConverter.ArrangmentObjToModel(arrangmentObj);
				entities.arrangement_package.Add(arrangmentModel);
				entities.SaveChanges();
				return arrangmentModel.id;
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public arrangement_package[] GetPackageArrangments(int dateFrom, int dateTo)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.arrangement_package> packageModels = new List<Models.arrangement_package>();

				if (dateFrom == 0 && dateTo == 0)
				{
					packageModels = entities.arrangement_package.ToList();
				}
				else
				{
					packageModels = entities.arrangement_package.Where(el => el.valid_from >= dateFrom && el.valid_to <= dateTo).ToList();
				}
				return packageModels.Select(el => ApartmentTypeConverter.ArrangmentModelToObj(el)).ToArray();
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool UpdatePackageArrangements(arrangement_package arrangementObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.arrangement_package arrangementModel = entities.arrangement_package.FirstOrDefault(el => el.id.Equals(arrangementObj.id));
				if (arrangementModel != null)
				{
					arrangementModel.id = arrangementObj.id;
					arrangementModel.title = arrangementObj.title;
					arrangementModel.description = arrangementObj.description;
					arrangementModel.max_resevations = arrangementObj.max_reservations.ToString();
					arrangementModel.valid_to = arrangementObj.valid_to;
					arrangementModel.valid_from = arrangementObj.valid_from;
					arrangementModel.price = (float) arrangementObj.price;

					entities.Entry(arrangementModel).State = System.Data.Entity.EntityState.Modified;
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

		public bool DeletePackageArrangments(int arrangementId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.arrangement_package arrangementModel = entities.arrangement_package.FirstOrDefault(el => el.id.Equals(arrangementId));
				if (arrangementModel != null)
				{
					entities.Entry(arrangementModel).State = System.Data.Entity.EntityState.Deleted;
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

		public int AddDiscount(discount discountObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = ApartmentTypeConverter.DiscountObjToModel(discountObj);
				entities.discounts.Add(discountModel);
				entities.SaveChanges();
				return discountModel.id;
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public bool UpdateDiscoint(discount discountObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = entities.discounts.FirstOrDefault(el => el.id.Equals(discountObj.id));
				if (discountModel != null)
				{
					discountModel.id = discountObj.id;
					discountModel.code = discountObj.code;
					discountModel.title = discountObj.title;
					discountModel.valid_to = discountObj.valid_to;
					discountModel.valid_from = discountObj.valid_from;
					discountModel.discount_percentage = (float) discountObj.discount_percentage;

					entities.Entry(discountModel).State = System.Data.Entity.EntityState.Modified;
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

		public bool DeleteDiscount(int discountId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = entities.discounts.FirstOrDefault(el => el.id.Equals(discountId));
				if (discountModel != null)
				{
					entities.Entry(discountModel).State = System.Data.Entity.EntityState.Deleted;
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

		public bool UpdateComplexInfo(complex_info infoObj)
		{
			StaticData.ComplexInfo.Title = infoObj.title;
			StaticData.ComplexInfo.Description = infoObj.description;
			StaticData.ComplexInfo.NumOfAppartments = infoObj.number_of_apartments;
			StaticData.ComplexInfo.Capacity = infoObj.capacity;
			return true;
		}

		/*
		public int AddCustomer(customer customerObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = ApartmentTypeConverter.CustomerObjToModel(customerObj);
				entities.customers.Add(customerModel);
				entities.SaveChanges();
				return customerModel.id;
			}
			catch (Exception ex)
			{
				return -1;
			}
		}

		public customer FindCustomer(int id, string firstName, string lastName, string taxNumber)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = entities.customers.FirstOrDefault(el => el.id.Equals(id) || el.first_name.Equals(firstName) || 
													el.last_name.Equals(lastName) || el.tax_number.Equals(taxNumber));
				if (customerModel != null)
				{
					//return ApartmentTypeConverter.CustomerModelToObj(customerModel);
				}
				else 
				{
					return null;
				}
			}
			catch (Exception ex)
			{
				return null;
			}
		}

		public bool UpdateCustomer(customer customerObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = entities.customers.FirstOrDefault(el => el.id.Equals(customerObj.id) &&
																						el.first_name.Equals(customerObj.first_name) &&
																						el.last_name.Equals(customerObj.last_name));
				if (customerModel != null)
				{
					customerModel.id = customerObj.id;
					customerModel.first_name = customerObj.first_name;
					customerModel.last_name = customerObj.last_name;
					customerModel.email = customerObj.email;
					customerModel.address = customerObj.address;
					customerObj.password = customerObj.password;

					entities.Entry(customerModel).State = System.Data.Entity.EntityState.Modified;
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

		public bool DeleteCustomer(int customerId)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = entities.customers.FirstOrDefault(el => el.id.Equals(customerId));
				if (customerModel != null)
				{
					entities.Entry(customerModel).State = System.Data.Entity.EntityState.Deleted;
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
		*/

	}
}
