using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibraryV1.Models.Utils
{
	class PublicTypeConverter
	{

		public static Types.booking_description_response BookingModelToBookingDescriptionResponse(Models.booking model)
		{
			Types.booking_description_response responseObj = new Types.booking_description_response();
			responseObj.apartment_id = model.apartment.id;
			responseObj.apartment_number = model.apartment.id.ToString();
			responseObj.apartment_title = model.apartment.title;
			responseObj.date_from = model.date_from;
			responseObj.date_to = model.date_to;
			responseObj.status = StringToBookingStatusEnum(model.status);

			return responseObj;
		}





		public static Types.booking_status StringToBookingStatusEnum(string status)
		{
			if (status == "pending")
			{
				return Types.booking_status.pending;
			}
			else if (status == "reserved")
			{
				return Types.booking_status.reserved;
			}
			else if (status == "completed")
			{
				return Types.booking_status.completed;
			}
			else //if (status == "cancelled")
			{
				return Types.booking_status.cancelled;
			}

		}

	}
}

