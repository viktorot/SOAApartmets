﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibraryV1.External
{
	class AquaParkAccess
	{

		public static AquaPark.Dogodek[] GetAllEvents()
		{
			AquaPark.DogodkiServiceClient client = new AquaPark.DogodkiServiceClient();
			AquaPark.Dogodek[] dogodki = client.VrniDogodke();

			return dogodki;
		}

		public static int GetAvailablePlacesForEvent(int eventId)
		{
			AquaPark.DogodkiServiceClient client = new AquaPark.DogodkiServiceClient();
			return client.VrniSteviloProstihMestDogodka(eventId);
		}

		public static bool ReserveAndPayForEvent(int eventId, int numOfPeople, string TRR)
		{
			AquaPark.DogodkiServiceClient client = new AquaPark.DogodkiServiceClient();
			AquaPark.Prijava prijava = client.PrijavaNaDogodek(eventId, "test", "test", numOfPeople, true);
			return client.PlacajPrijavo(prijava.IdPrijava, "test", "test", TRR, false);
		}



	}
}