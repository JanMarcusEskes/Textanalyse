using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Textanalyse
{
	public class Statistiks
	{
		int anzahlWörter;
		int anzahlZeichen;
		int anzahlVokale;
		int sonderzeichen;
		int[] buchstaben = new int[26];

		public int AnzahlWörter
		{
			get
			{
				return anzahlWörter;
			}
			set
			{
				anzahlWörter = value;
			}
		}
		public int AnzahlZeichen
		{
			get
			{
				return anzahlZeichen;
			}
			set
			{
				anzahlZeichen = value;
			}
		}
		public int AnzahlVokale
		{
			get
			{
				return anzahlVokale;
			}
			set
			{
				anzahlVokale = value;
			}
		}
		public int Sonderzeichen
		{
			get
			{
				return sonderzeichen;
			}
			set
			{
				sonderzeichen = value;
			}
		}
		public int[] Buchstaben
		{
			get
			{
				return buchstaben;
			}
			set
			{
				buchstaben = value;
			}
		}

		public string[] ToStringArray()
		{
			string[] output = new string[30];
			for (char i = 'A'; 'Z' > i; i++)
			{
				output[i - 'A'] = (char)i + ": " + buchstaben[i - 'A'];
			}
			output[29] = "Anzahl Wörter:        " + AnzahlWörter;
			output[28] = "Anzahl Zeichen:       " + AnzahlZeichen;
			output[27] = "Anzahl Vokale:        " + AnzahlVokale;
			output[26] = "Anzahl Sonderzeichen: " + Sonderzeichen;

			return output;


	}
	}
}
