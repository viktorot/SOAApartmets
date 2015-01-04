using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;

namespace ApartmentComplexServiceLibraryV1.Faults
{
	[DataContract(Name="NotFoundException")]
	class NotFoundException
	{
		[DataMember]
		public string ItemId { get; set; }
	}
}
