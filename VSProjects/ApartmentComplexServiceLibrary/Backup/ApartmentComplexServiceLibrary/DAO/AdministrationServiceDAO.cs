using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ApartmentComplexServiceLibrary.ServiceInterfaces.AdministrationService;
using ApartmentComplexServiceLibrary.Types;
using ApartmentComplexServiceLibrary.Models.Utils;

namespace ApartmentComplexServiceLibrary.DAO
{
	class AdministrationServiceDAO
	{
		public bool AddApartment(apartment apartmentObj)
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
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public apartment FindApartment(int id, int numOfBeds, string apartmentNumber)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.apartment apartmentModel = entities.apartments.FirstOrDefault(el => el.id.Equals(id));

				if (apartmentModel != null)
				{
					apartment apartmentObj = new apartment
					{
						id = apartmentModel.id,
						title = apartmentModel.title,
						description = apartmentModel.description,
						latitude = (double) apartmentModel.latitude,
						longitude = (double) apartmentModel.longitude,
						no_king_beds = (int) apartmentModel.no_king_beds,
						no_extra_beds = (int)apartmentModel.no_extra_beds,
						no_single_beds = (int)apartmentModel.no_single_beds,
						pet_friendly = (bool) apartmentModel.pet_friendly,
						internet = (bool) apartmentModel.internet,
						air_conditioning = (bool) apartmentModel.air_conditioning,
						tv = (bool) apartmentModel.tv,
						kitchen = (bool )apartmentModel.kitchen,
						accessible = (bool) apartmentModel.accessible,
						class_stars = (int) apartmentModel.class_stars
					};

					return apartmentObj;
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

		public bool DeleteApartment(apartment apartmentObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.apartment apartmentModel = entities.apartments.FirstOrDefault(el => el.id.Equals(apartmentObj.id));

				if (apartmentModel != null)
				{
					entities.Entry(apartmentModel).State = System.Data.Entity.EntityState.Deleted;
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

		public bool AddBooking(int userId, int apartmentId, int dateFrom, int dateTo, int packagArrangementId, string discountCode)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = entities.discounts.FirstOrDefault(el => el.code.Equals(discountCode));
				
				Models.booking bookingModel = new Models.booking
				{
					customer_idcustomer = userId,
					date_from = dateFrom,
					date_to = dateTo,
					arrangement_package_id = packagArrangementId,
					discounts_id = discountModel != null ? discountModel.id : -1
				};
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public booking GetBooking(int id, int userId, int apartmentId, int dateFrom, int dateTo)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.booking bookingModel = entities.bookings.FirstOrDefault(el => el.id.Equals(id));

				if (bookingModel != null)
				{
					booking bookingObj = new booking
					{
						id = bookingModel.id,
						date_from = bookingModel.date_from,
						date_to = bookingModel.date_to,
						customer = ApartmentTypeConverter.CustomerModelToObj(bookingModel.customer),
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
					bookingModel.customer = ApartmentTypeConverter.CustomerObjToModel(bookingObj.customer);
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

		public bool AddPackageArrangments(arrangement_package arrangmentObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.arrangement_package arrangmentModel = ApartmentTypeConverter.ArrangmentObjToModel(arrangmentObj);
				entities.arrangement_package.Add(arrangmentModel);
				entities.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public arrangement_package[] GetPackageArrangments(int dateFrom, int dateTo)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				List<Models.arrangement_package> packageModels = entities.arrangement_package.Where(el => el.valid_from >= dateFrom && el.valid_to <= dateTo).ToList();
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

		public bool DeletePackageArrangments(arrangement_package arrangementObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.arrangement_package arrangementModel = entities.arrangement_package.FirstOrDefault(el => el.id.Equals(arrangementObj.id));
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

		public bool AddDiscount(discount discountObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = ApartmentTypeConverter.DiscountObjToModel(discountObj);
				entities.discounts.Add(discountModel);
				entities.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
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

		public bool DeleteDiscount(discount discountObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.discount discountModel = entities.discounts.FirstOrDefault(el => el.id.Equals(discountObj.id));
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
			throw new NotImplementedException();
		}

		public bool AddCustomer(customer customerObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = ApartmentTypeConverter.CustomerObjToModel(customerObj);
				entities.customers.Add(customerModel);
				entities.SaveChanges();
				return true;
			}
			catch (Exception ex)
			{
				return false;
			}
		}

		public customer FindCustomer(int id, string firstName, string lastName, string taxNumber)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = entities.customers.FirstOrDefault(el => el.id.Equals(id) && el.first_name.Equals(firstName) && el.last_name.Equals(lastName));
				if (customerModel != null)
				{
					return ApartmentTypeConverter.CustomerModelToObj(customerModel);
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

		public bool DeleteCustomer(customer customerObj)
		{
			Models.ApartmentEntities entities = new Models.ApartmentEntities();
			try
			{
				Models.customer customerModel = entities.customers.FirstOrDefault(el => el.id.Equals(customerObj.id) &&
																		el.first_name.Equals(customerObj.first_name) &&
																		el.last_name.Equals(customerObj.last_name));
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


	}
}
