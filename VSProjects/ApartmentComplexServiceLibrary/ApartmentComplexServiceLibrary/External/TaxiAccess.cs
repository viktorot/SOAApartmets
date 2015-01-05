using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibraryV1.External
{
	public class TaxiAccess
	{

		public static void OrderTaxi(string destination, int numOfPeople, DateTime timeOfDeparture)
		{
			Taxi.UporabnikiClient client = new Taxi.UporabnikiClient();
			Taxi.Narocilo narocilo = new Taxi.Narocilo();

			narocilo.ImeUporabnika = "ApartmanskoNaselje";
			narocilo.EnaslovUporabnika = "apartman@naselje.org";
			narocilo.StartRelacije = StaticData.ComplexInfo.Address;
			narocilo.CiljRelacije = destination;
			narocilo.SteviloOseb = numOfPeople;
			narocilo.Prevzem = timeOfDeparture;

			client.OddajNarocilo(narocilo);
		}

	}
}
