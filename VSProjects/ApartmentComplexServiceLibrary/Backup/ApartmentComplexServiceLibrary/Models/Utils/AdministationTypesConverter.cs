using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibrary.Models.Utils
{
	class ApartmentTypeConverter
	{

		public static Types.apartment ApartmentModelToObj(Models.apartment model) 
		{
			Types.apartment obj = new Types.apartment
			{
				id = model.id,
				title = model.title,
				description = model.description,
				latitude = (int) model.latitude,
				longitude = (int) model.longitude,
				no_extra_beds = (int) model.no_extra_beds,
				no_king_beds = (int) model.no_king_beds,
				no_single_beds = (int) model.no_single_beds,
				pet_friendly = (bool) model.pet_friendly,
				internet = (bool) model.internet,
				air_conditioning = (bool) model.air_conditioning,
				tv = (bool) model.tv,
				kitchen = (bool) model.kitchen,
				accessible = (bool) model.accessible,
				class_stars = (int) model.class_stars
			};

			return obj;
		}

		public static Models.apartment ApartmentObjToModel(Types.apartment obj)
		{
			Models.apartment model = new Models.apartment
			{
				id = obj.id,
				title = obj.title,
				description = obj.description,
				latitude = (int)obj.latitude,
				longitude = (int)obj.longitude,
				no_extra_beds = (int)obj.no_extra_beds,
				no_king_beds = (int)obj.no_king_beds,
				no_single_beds = (int)obj.no_single_beds,
				pet_friendly = (bool)obj.pet_friendly,
				internet = (bool)obj.internet,
				air_conditioning = (bool)obj.air_conditioning,
				tv = (bool)obj.tv,
				kitchen = (bool)obj.kitchen,
				accessible = (bool)obj.accessible,
				class_stars = (int)obj.class_stars
			};
			return model;
		}

		public static Types.customer CustomerModelToObj(Models.customer model)
		{
			Types.customer obj = new Types.customer
			{
				id = model.id,
				first_name = model.first_name,
				last_name = model.last_name,
				email = model.email,
				address = model.address,
				password = model.password
			};

			return obj;
		}

		public static Models.customer CustomerObjToModel(Types.customer obj)
		{
			Models.customer model = new Models.customer
			{
				id = obj.id,
				first_name = obj.first_name,
				last_name = obj.last_name,
				email = obj.email,
				address = obj.address,
				password = obj.password
			};

			return model;
		}

		public static Types.discount DiscountModelToObj(Models.discount model)
		{
			Types.discount obj = new Types.discount
			{
				id = model.id,
				code = model.code,
				title = model.title,
				description = model.description,
				valid_from = model.valid_from,
				valid_to = model.valid_to,
				discount_percentage = model.discount_percentage
			};
			return obj;
		}

		public static Models.discount DiscountObjToModel(Types.discount obj)
		{
			Models.discount model = new Models.discount
			{
				id = obj.id,
				code = obj.code,
				title = obj.title,
				description = obj.description,
				valid_from = obj.valid_from,
				valid_to = obj.valid_to,
				discount_percentage = (float) obj.discount_percentage
			};
			return model;
		}

		public static Types.payment_method PaymentModelToObj(Models.payment_method model)
		{
			Types.payment_method obj = new Types.payment_method
			{
				id = model.id,
				card_number = model.card_number,
				bank_payment = (bool) model.bank_payment
			};
			return obj;
		}

		public static Models.payment_method PaymentObjToModel(Types.payment_method obj)
		{
			Models.payment_method model = new Models.payment_method
			{
				id = obj.id,
				card_number = obj.card_number,
				bank_payment = (bool)obj.bank_payment
			};
			return model;
		}

		public static Models.booking BookingObjToModel(Types.booking obj)
		{
			Models.booking model = new Models.booking 
			{
				id = obj.id,
				date_from = obj.date_from,
				date_to = obj.date_to,
				status = obj.status.ToString(),
				apartment = ApartmentObjToModel(obj.apartment),
				payment_method = PaymentObjToModel(obj.payment),
				discount = DiscountObjToModel(obj.discount)
			};
			return model;
		}

		public static Types.booking BookingModelToObj(Models.booking model)
		{
			Types.booking obj = new Types.booking
			{
				id = model.id,
				date_from = model.date_from,
				date_to = model.date_to,
				status = BookingStatusStringToEnum(model.status),
				apartment = ApartmentModelToObj(model.apartment),
				payment = PaymentModelToObj(model.payment_method),
				discount = DiscountModelToObj(model.discount)
			};
			return obj;
		}

		public static Models.arrangement_package ArrangmentObjToModel(Types.arrangement_package obj)
		{
			Models.arrangement_package model = new Models.arrangement_package
			{
				id = obj.id,
				title = obj.title,
				description = obj.description,
				max_resevations = obj.max_reservations.ToString(),
				valid_from = obj.valid_from,
				valid_to = obj.valid_to,
				price = (float) obj.price
			};
			return model;
		}

		public static Types.arrangement_package ArrangmentModelToObj(Models.arrangement_package model)
		{
			Types.arrangement_package obj = new Types.arrangement_package
			{
				id = model.id,
				title = model.title,
				description = model.description,
				max_reservations = Convert.ToInt32(model.max_resevations),
				valid_from = (int) model.valid_from,
				valid_to = (int) model.valid_to,
				price = (float) model.price
			};
			return obj;
		}
		





		public static Types.booking_status BookingStatusStringToEnum(string status)
		{
			if (status == Types.booking_status.cancelled.ToString())
			{
				return Types.booking_status.cancelled;
			}
			else if (status == Types.booking_status.completed.ToString())
			{
				return Types.booking_status.completed;
			}
			else if (status == Types.booking_status.pending.ToString())
			{
				return Types.booking_status.pending;
			}
			else
			{
				return Types.booking_status.reserved;
			}
		}
	}
}
