using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentComplexServiceLibraryV1.External
{
	public class BankAccess
	{
		private static void CreateAccountForUs()
		{

		}

		private static void OpenEBill()
		{

		}

		public static void PlayEBill(int bill_id, string trr, string pin, double amount)
		{
			Bank.BankaClient client = new Bank.BankaClient();

			Bank.Racun prejemnik = new Bank.Racun();
			prejemnik.stevilkaTRR = trr;

			Bank.Racun izdajatelj = new Bank.Racun();
			izdajatelj.stevilkaTRR = StaticData.ComplexInfo.TRR;

			Bank.Postavka p = new Bank.Postavka();
			p.DavcnaStopnja = 22;
			p.Enota = "eur";
			p.Kolicina = 1;
			p.Naziv = "Rezrvacija";
			p.Znesek = amount;
			p.ZnesekDavek = 2;

			Bank.eRacun eracun = new Bank.eRacun();
			eracun.NazivRacuna = "Rezervacija #1";
			eracun.AliJePlacanRacun = false;
			eracun.ZnesekRacuna = (decimal) amount;
			eracun.RokPlacilaRacuna = DateTime.Now;
			eracun.DatumIzdajeRacuna = DateTime.Now.AddDays(10);
			eracun.RacunIzdajatelj = izdajatelj;
			eracun.RacunPrejemnik = prejemnik;
			eracun.ValutaZneska = "evro";
			eracun.VsePostavkeNaRacunu = new Bank.Postavka[] { p };

			client.UstvarjanjeERacuna("SI56101011648615617", "2792", eracun);
		}

		public static void PayWithCard(string trr, string pin, double amount)
		{
			Bank.BankaClient client = new Bank.BankaClient();
			client.PlaciloSPlacilnoKartico(trr, pin, (decimal)amount, StaticData.ComplexInfo.TRR);
		}

		public static bool HasSufficientAmount(string trr, string pin, double amount)
		{
			Bank.BankaClient client = new Bank.BankaClient();
			return amount <= (double) client.PregledStanja(trr, pin);
		}

	}
}
