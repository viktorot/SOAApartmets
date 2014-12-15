using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibrary.Types.Rest
{
	[DataContract]
	public class RestApartment
	{
		[DataMember]
		public string title { get; set; }
		[DataMember]
		public int no_of_beds { get; set; }
		[DataMember]
		public bool wifi { get; set; }
	}
}
