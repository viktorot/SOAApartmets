using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApartmentComplexServiceLibraryV1.Types;

namespace ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService
{
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ServiceModel.ServiceContractAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService", ConfigurationName = "ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.IApartmentAdministrationService")]
	public interface IApartmentAdministrationService
	{

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message AddApartmentRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/AddApartment")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddApartmentResponse AddApartment(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddApartmentRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message FindApartmentRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/FindApartment")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.FindApartmentResponse FindApartment(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.FindApartmentRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message UpdateApartmentRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/UpdateApartment")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateApartmentResponse UpdateApartment(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateApartmentRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message DeleteApartmentRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/DeleteApartment")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.DeleteApartmentResponse DeleteApartment(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.DeleteApartmentRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message AddBookingRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/AddBooking")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddBookingResponse AddBooking(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddBookingRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message GetBookingRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/GetBooking")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.GetBookingResponse GetBooking(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.GetBookingRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message UpdateBookingRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/UpdateBooking")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateBookingResponse UpdateBooking(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateBookingRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message AddPackageArrangementsRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/AddPackageArrangeme" +
			"nts")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddPackageArrangementsResponse AddPackageArrangements(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddPackageArrangementsRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message GetPackageArrangementsRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/GetPackageArrangeme" +
			"nts")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.GetPackageArrangementsResponse GetPackageArrangements(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.GetPackageArrangementsRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message UpdatePackageArrangementsRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/UpdatePackageArrang" +
			"ements")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdatePackageArrangementsResponse UpdatePackageArrangements(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdatePackageArrangementsRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message DeletePackageArrangementsRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/DeletePackageArrang" +
			"ements")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.DeletePackageArrangementsResponse DeletePackageArrangements(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.DeletePackageArrangementsRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message AddDiscountRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/AddDiscount")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddDiscountResponse AddDiscount(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.AddDiscountRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message UpdateDiscountRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/UpdateDiscount")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateDiscountResponse UpdateDiscount(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateDiscountRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message DeleteDiscountRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/DeleteDiscount")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.DeleteDiscountResponse DeleteDiscount(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.DeleteDiscountRequest request);

		// CODEGEN: Generating message contract since the wrapper namespace (http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages) of message UpdateComplexInfoRequest does not match the default value (http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService)
		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/UpdateComplexInfo")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateComplexInfoResponse UpdateComplexInfo(ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.UpdateComplexInfoRequest request);

		[System.ServiceModel.OperationContractAttribute(Action = "http://soa.appartments/SOATravel/apartma2/services/v1/ApartmentAdministrationService/GetHotelServices")]
		[System.ServiceModel.XmlSerializerFormatAttribute()]
		ApartmentComplexServiceLibraryV1.ServiceInterfaces.AdministrationService.GetHotelServicesResponse GetHotelServices();
	}


	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddApartmentRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddApartmentRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.apartment apartment;

		public AddApartmentRequest()
		{
		}

		public AddApartmentRequest(ApartmentComplexServiceLibraryV1.Types.apartment apartment)
		{
			this.apartment = apartment;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddApartmentResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddApartmentResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public AddApartmentResponse()
		{
		}

		public AddApartmentResponse(bool status, int id)
		{
			this.status = status;
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "FindApartmentRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class FindApartmentRequest
	{
		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int num_of_beds;

		public FindApartmentRequest()
		{
		}

		public FindApartmentRequest(int id, int num_of_beds)
		{
			this.id = id;
			this.num_of_beds = num_of_beds;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "FindApartmentResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class FindApartmentResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.apartment[] apartment;

		public FindApartmentResponse()
		{
		}

		public FindApartmentResponse(ApartmentComplexServiceLibraryV1.Types.apartment[] apartment)
		{
			this.apartment = apartment;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateApartmentRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateApartmentRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.apartment apartment;

		public UpdateApartmentRequest()
		{
		}

		public UpdateApartmentRequest(ApartmentComplexServiceLibraryV1.Types.apartment apartment)
		{
			this.apartment = apartment;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateApartmentResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateApartmentResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public UpdateApartmentResponse()
		{
		}

		public UpdateApartmentResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteApartmentRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeleteApartmentRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public DeleteApartmentRequest()
		{
		}

		public DeleteApartmentRequest(int id)
		{
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteApartmentResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeleteApartmentResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public DeleteApartmentResponse()
		{
		}

		public DeleteApartmentResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddBookingRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddBookingRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int user_trr;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string pin_number;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int apartment_id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 3)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 4)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 5)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int package_arrangment_id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 6)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string discount_code;

		public AddBookingRequest()
		{
		}

		public AddBookingRequest(int user_trr, int apartment_id, int date_from, int date_to, int package_arrangment_id, string discount_code)
		{
			this.user_trr = user_trr;
			this.apartment_id = apartment_id;
			this.date_from = date_from;
			this.date_to = date_to;
			this.package_arrangment_id = package_arrangment_id;
			this.discount_code = discount_code;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddBookingResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddBookingResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool booking_status;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public AddBookingResponse()
		{
		}

		public AddBookingResponse(bool booking_status, int id)
		{
			this.booking_status = booking_status;
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class GetBookingRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int user_id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int apartment_id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 3)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 4)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		public GetBookingRequest()
		{
		}

		public GetBookingRequest(int id, int user_id, int apartment_id, int date_from, int date_to)
		{
			this.id = id;
			this.user_id = user_id;
			this.apartment_id = apartment_id;
			this.date_from = date_from;
			this.date_to = date_to;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetBookingResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class GetBookingResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.booking booking;

		public GetBookingResponse()
		{
		}

		public GetBookingResponse(ApartmentComplexServiceLibraryV1.Types.booking booking)
		{
			this.booking = booking;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateBookingRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateBookingRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.booking booking;

		public UpdateBookingRequest()
		{
		}

		public UpdateBookingRequest(ApartmentComplexServiceLibraryV1.Types.booking booking)
		{
			this.booking = booking;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateBookingResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateBookingResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public UpdateBookingResponse()
		{
		}

		public UpdateBookingResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddPackageArrangementRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddPackageArrangementsRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.arrangement_package package_arrangements;

		public AddPackageArrangementsRequest()
		{
		}

		public AddPackageArrangementsRequest(ApartmentComplexServiceLibraryV1.Types.arrangement_package package_arrangements)
		{
			this.package_arrangements = package_arrangements;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddPackageArrangementResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddPackageArrangementsResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public AddPackageArrangementsResponse()
		{
		}

		public AddPackageArrangementsResponse(bool status, int id)
		{
			this.status = status;
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetPackageArrangementRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class GetPackageArrangementsRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_from;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int date_to;

		public GetPackageArrangementsRequest()
		{
		}

		public GetPackageArrangementsRequest(int date_from, int date_to)
		{
			this.date_from = date_from;
			this.date_to = date_to;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetPackageArrangementResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class GetPackageArrangementsResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute("arrangments_result", Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.arrangement_package[] arrangments_result;

		public GetPackageArrangementsResponse()
		{
		}

		public GetPackageArrangementsResponse(ApartmentComplexServiceLibraryV1.Types.arrangement_package[] arrangments_result)
		{
			this.arrangments_result = arrangments_result;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdatePackageArrangementRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdatePackageArrangementsRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.arrangement_package package_arrangements;

		public UpdatePackageArrangementsRequest()
		{
		}

		public UpdatePackageArrangementsRequest(ApartmentComplexServiceLibraryV1.Types.arrangement_package package_arrangements)
		{
			this.package_arrangements = package_arrangements;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdatePackageArrangementResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdatePackageArrangementsResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public UpdatePackageArrangementsResponse()
		{
		}

		public UpdatePackageArrangementsResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeletePackageArrangementRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeletePackageArrangementsRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public DeletePackageArrangementsRequest()
		{
		}

		public DeletePackageArrangementsRequest(int id)
		{
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeletePackageArrangementResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeletePackageArrangementsResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public DeletePackageArrangementsResponse()
		{
		}

		public DeletePackageArrangementsResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddDiscountRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddDiscountRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.discount discounts;

		public AddDiscountRequest()
		{
		}

		public AddDiscountRequest(ApartmentComplexServiceLibraryV1.Types.discount discounts)
		{
			this.discounts = discounts;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddDiscountResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddDiscountResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public AddDiscountResponse()
		{
		}

		public AddDiscountResponse(bool status, int id)
		{
			this.status = status;
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateDiscountRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateDiscountRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.discount discounts;

		public UpdateDiscountRequest()
		{
		}

		public UpdateDiscountRequest(ApartmentComplexServiceLibraryV1.Types.discount discounts)
		{
			this.discounts = discounts;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateDiscountResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateDiscountResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public UpdateDiscountResponse()
		{
		}

		public UpdateDiscountResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteDiscountRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeleteDiscountRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public DeleteDiscountRequest()
		{
		}

		public DeleteDiscountRequest(int id)
		{
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteDiscountResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeleteDiscountResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public DeleteDiscountResponse()
		{
		}

		public DeleteDiscountResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateComplexInfoRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateComplexInfoRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.complex_info complex;

		public UpdateComplexInfoRequest()
		{
		}

		public UpdateComplexInfoRequest(ApartmentComplexServiceLibraryV1.Types.complex_info complex)
		{
			this.complex = complex;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateComplexInfoResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateComplexInfoResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public UpdateComplexInfoResponse()
		{
		}

		public UpdateComplexInfoResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "GetHotelServicesResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class GetHotelServicesResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public Types.hotel_service[] services;

		public GetHotelServicesResponse()
		{
		}

		public GetHotelServicesResponse(hotel_service[] services)
		{
			this.services = services;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddCustomerRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddCustomerRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.customer customer;

		public AddCustomerRequest()
		{
		}

		public AddCustomerRequest(ApartmentComplexServiceLibraryV1.Types.customer customer)
		{
			this.customer = customer;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "AddCustomerResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class AddCustomerResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public AddCustomerResponse()
		{
		}

		public AddCustomerResponse(bool status, int id)
		{
			this.status = status;
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "FindCustomerRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class FindCustomerRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 1)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string first_name;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 2)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string last_name;

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 3)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public string tax_number;

		public FindCustomerRequest()
		{
		}

		public FindCustomerRequest(int id, string first_name, string last_name, string tax_number)
		{
			this.id = id;
			this.first_name = first_name;
			this.last_name = last_name;
			this.tax_number = tax_number;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "FindCustomerResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class FindCustomerResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.customer customer;

		public FindCustomerResponse()
		{
		}

		public FindCustomerResponse(ApartmentComplexServiceLibraryV1.Types.customer customer)
		{
			this.customer = customer;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateCustomerRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateCustomerRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public ApartmentComplexServiceLibraryV1.Types.customer customer;

		public UpdateCustomerRequest()
		{
		}

		public UpdateCustomerRequest(ApartmentComplexServiceLibraryV1.Types.customer customer)
		{
			this.customer = customer;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "UpdateCustomerResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class UpdateCustomerResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public UpdateCustomerResponse()
		{
		}

		public UpdateCustomerResponse(bool status)
		{
			this.status = status;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteCustomerRequest", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeleteCustomerRequest
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public int id;

		public DeleteCustomerRequest()
		{
		}

		public DeleteCustomerRequest(int id)
		{
			this.id = id;
		}
	}

	[System.Diagnostics.DebuggerStepThroughAttribute()]
	[System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
	[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
	[System.ServiceModel.MessageContractAttribute(WrapperName = "DeleteCustomerResponse", WrapperNamespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", IsWrapped = true)]
	public partial class DeleteCustomerResponse
	{

		[System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://soa.appartments/SOATravel/apartma2/services/v1/administration_messages", Order = 0)]
		[System.Xml.Serialization.XmlElementAttribute(Form = System.Xml.Schema.XmlSchemaForm.Unqualified)]
		public bool status;

		public DeleteCustomerResponse()
		{
		}

		public DeleteCustomerResponse(bool status)
		{
			this.status = status;
		}
	}
}
