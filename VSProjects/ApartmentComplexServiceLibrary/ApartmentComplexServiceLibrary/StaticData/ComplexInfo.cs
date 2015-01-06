using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibraryV1.StaticData
{
	class ComplexInfo
	{
		public static string Title { get; set; }
		public static string Description { get; set; }
		public static int NumOfAppartments { get; set; }
		public static int Capacity { get; set; }
		public static string Address { get; set; }

		public static long TRR { get { return 56101010792777664;} }
		public static int Pin { get { return 4931; } }
	}
}
