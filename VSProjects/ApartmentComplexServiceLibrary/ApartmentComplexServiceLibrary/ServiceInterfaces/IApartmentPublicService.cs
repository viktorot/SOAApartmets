using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentComplexServiceLibraryV1.Types;

namespace ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.ServiceContractAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService", ConfigurationName = "ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.IApartmentPublicService")]
	public interface IApartmentPublicService
	{

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message SearchRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/Search")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.SearchResponse Search(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.SearchRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message AdvancedSearchRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/AdvancedSearch")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.SearchResponse AdvancedSearch(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.AdvancedSearchRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message MakeBookingRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/MakeBooking")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.MakeBookingResponse MakeBooking(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.MakeBookingRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message CancelBookingRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/CancelBooking")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.CancelBookingResponse CancelBooking(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.CancelBookingRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message GetBookingRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetBooking")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetBookingResponse GetBooking(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetBookingRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message GetBookingsForApppartmentRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetBookingsForApppartment")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetBookingsForApppartmentResponse GetBookingsForApppartment(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetBookingsForApppartmentRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message GetBookingsForUserRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetBookingsForUser")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetBookingsForUserResponse GetBookingsForUser(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetBookingsForUserRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message GetPackagesArrangementsRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetPackagesArrangements")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetPackagesArrangementsResponse GetPackagesArrangements(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetPackagesArrangementsRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/public_messages) of message GetDiscountsRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetDiscounts")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetDiscountsResponse GetDiscounts(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetDiscountsRequest request);

		// CODEGEN: Generating message contract since the operation has multiple return values.
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetComplexInfo")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetComplexInfoResponse GetComplexInfo(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetComplexInfoRequest request);

		// CODEGEN: Generating message contract since the operation has multiple return values.
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/PublicApartmentService/GetApartmentInfo")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetApartmentInfoResponse GetApartmentInfo(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.GetApartmentInfoRequest request);
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "SearchRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class SearchRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int number_of_beds;

		public SearchRequest()
		{
		}

		public SearchRequest(int date_from, int date_to, int number_of_beds)
		{
			this.date_from = date_from;
			this.date_to = date_to;
			this.number_of_beds = number_of_beds;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "SearchResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class SearchResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("searchResults", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.apartment[] searchResults;

		public SearchResponse()
		{
		}

		public SearchResponse(ApartmentComplexServiceLibraryV1.Types.apartment[] searchResults)
		{
			this.searchResults = searchResults;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AdvancedSearchRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class AdvancedSearchRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int number_of_beds;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 3)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool pet_friendly;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 4)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int no_king_beds;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 5)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int no_single_beds;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 6)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int no_extra_beds;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 7)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool internet;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 8)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool air_conditioning;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 9)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool tv;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 10)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool kitchen;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 11)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int class_stars;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 12)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool balcony;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 13)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool accessible;

		public AdvancedSearchRequest()
		{
		}

		public AdvancedSearchRequest(int number_of_beds, int date_from, int date_to, bool pet_friendly, int no_king_beds, int no_single_beds, int no_extra_beds, bool internet, bool air_conditioning, bool tv, bool kitchen, int class_stars, bool balcony, bool accessible)
		{
			this.number_of_beds = number_of_beds;
			this.date_from = date_from;
			this.date_to = date_to;
			this.pet_friendly = pet_friendly;
			this.no_king_beds = no_king_beds;
			this.no_single_beds = no_single_beds;
			this.no_extra_beds = no_extra_beds;
			this.internet = internet;
			this.air_conditioning = air_conditioning;
			this.tv = tv;
			this.kitchen = kitchen;
			this.class_stars = class_stars;
			this.balcony = balcony;
			this.accessible = accessible;
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/types")]
	public enum booking_response
	{

		/// <remarks/>
		booked,

		/// <remarks/>
		failed,
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "MakeBookingRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class MakeBookingRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string user_trr;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string pin_number;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int apartment_id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 3)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 4)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 5)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int package_arrangment_id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 6)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string discount_code;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 7)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool bank_payment;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 8)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int num_of_people;

		public MakeBookingRequest()
		{
		}

		public MakeBookingRequest(string user_trr, string pin, int apartment_id, int date_from, int date_to, int package_arrangment_id, string discount_code, bool payment, int num_of_people)
		{
			this.user_trr = user_trr;
			this.pin_number = pin;
			this.apartment_id = apartment_id;
			this.date_from = date_from;
			this.date_to = date_to;
			this.package_arrangment_id = package_arrangment_id;
			this.discount_code = discount_code;
			this.bank_payment = payment;
			this.num_of_people = num_of_people;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "MakeBookingResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class MakeBookingResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.booking_response booking_status;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public MakeBookingResponse()
		{
		}

		public MakeBookingResponse(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.booking_response booking_status, int id)
		{
			this.booking_status = booking_status;
			this.id = id;
		}
	}

	/// <remarks/>
	[System.CodeDom.Compiler.GeneratedCodeAttribute("svcutil", "4.0.30319.17929")]
	[System.SerializableAttribute()]
	[System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/types")]
	public enum cancel_booking_response
	{

		/// <remarks/>
		cancelled,

		/// <remarks/>
		failed,
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "CancelBookingRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class CancelBookingRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int booking_id;

		public CancelBookingRequest()
		{
		}

		public CancelBookingRequest(int booking_id)
		{
			this.booking_id = booking_id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "CancelBookingResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class CancelBookingResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.cancel_booking_response booking_status;

		public CancelBookingResponse()
		{
		}

		public CancelBookingResponse(ApartmentComplexServiceLibraryV1.ServiceInterfaces.PublicService.cancel_booking_response booking_status)
		{
			this.booking_status = booking_status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetBookingRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int booking_id;

		public GetBookingRequest()
		{
		}

		public GetBookingRequest(int booking_id)
		{
			this.booking_id = booking_id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetBookingResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("bookings", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.booking_description_response[] bookings;

		public GetBookingResponse()
		{
		}

		public GetBookingResponse(ApartmentComplexServiceLibraryV1.Types.booking_description_response[] bookings)
		{
			this.bookings = bookings;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingsForApartmentRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetBookingsForApppartmentRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int apartment_id;

		public GetBookingsForApppartmentRequest()
		{
		}

		public GetBookingsForApppartmentRequest(int apartment_id)
		{
			this.apartment_id = apartment_id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingsForApartmentResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetBookingsForApppartmentResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("bookings", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.booking_description_response[] bookings;

		public GetBookingsForApppartmentResponse()
		{
		}

		public GetBookingsForApppartmentResponse(ApartmentComplexServiceLibraryV1.Types.booking_description_response[] bookings)
		{
			this.bookings = bookings;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingsForUserRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetBookingsForUserRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string user_trr;

		public GetBookingsForUserRequest()
		{
		}

		public GetBookingsForUserRequest(string user_trr)
		{
			this.user_trr = user_trr;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingsForUserResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetBookingsForUserResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("bookings", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.booking_description_response[] bookings;

		public GetBookingsForUserResponse()
		{
		}

		public GetBookingsForUserResponse(ApartmentComplexServiceLibraryV1.Types.booking_description_response[] bookings)
		{
			this.bookings = bookings;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetPackageArrangementsRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetPackagesArrangementsRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		public GetPackagesArrangementsRequest()
		{
		}

		public GetPackagesArrangementsRequest(int date_from, int date_to)
		{
			this.date_from = date_from;
			this.date_to = date_to;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetPackageArrangementsResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetPackagesArrangementsResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("arrangments_result", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.arrangement_package[] arrangments_result;

		public GetPackagesArrangementsResponse()
		{
		}

		public GetPackagesArrangementsResponse(ApartmentComplexServiceLibraryV1.Types.arrangement_package[] arrangments_result)
		{
			this.arrangments_result = arrangments_result;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetDiscountsRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetDiscountsRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		public GetDiscountsRequest()
		{
		}

		public GetDiscountsRequest(int date_from, int date_to)
		{
			this.date_from = date_from;
			this.date_to = date_to;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetDiscountsResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetDiscountsResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("discounts_result", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.discount[] discounts_result;

		public GetDiscountsResponse()
		{
		}

		public GetDiscountsResponse(ApartmentComplexServiceLibraryV1.Types.discount[] discounts_result)
		{
			this.discounts_result = discounts_result;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetComplexInfoRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetComplexInfoRequest
	{

		public GetComplexInfoRequest()
		{
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetComplexInfoResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetComplexInfoResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string decription;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double longitude;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public double latitude;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 3)]
		[System.Xml.Serialization.XmlElementAttribute("images", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] images;

		public GetComplexInfoResponse()
		{
		}

		public GetComplexInfoResponse(string decription, double longitude, double latitude, string[] images)
		{
			this.decription = decription;
			this.longitude = longitude;
			this.latitude = latitude;
			this.images = images;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetApartmentInfoRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetApartmentInfoRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int apartment_id;

		public GetApartmentInfoRequest()
		{
		}

		public GetApartmentInfoRequest(int apartment_id)
		{
			this.apartment_id = apartment_id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetApartmentInfoResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", IsWrapped = true)]
	public partial class GetApartmentInfoResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.apartment apartment;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/public_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute("images", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string[] images;

		public GetApartmentInfoResponse()
		{
		}

		public GetApartmentInfoResponse(ApartmentComplexServiceLibraryV1.Types.apartment apartment, string[] images)
		{
			this.apartment = apartment;
			this.images = images;
		}
	}
}
