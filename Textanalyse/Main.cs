using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Textanalyse
{
	public partial class Main : Form
	{
		public Main()
		{
			InitializeComponent();
		}

		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			Statistiks analyse = new Statistiks();

			char[] buchstaben = txtInput.Text.ToUpper().ToCharArray();
			int vokale = 0, wörter = 1, zeichen = 0, sonderzeichen = 0;
			int[] buchstabenZahlen = new int[26];
			char vorgänger = '1';
			foreach (char buchstabe in buchstaben)
			{
				if (buchstabe == 'A' || buchstabe == 'E' || buchstabe == 'I' || buchstabe == 'O' || buchstabe == 'U')
					vokale++;
				if (buchstabe >= 'A' && buchstabe <= 'Z')
					buchstabenZahlen[buchstabe - 'A']++;
				if (buchstabe != ' ' && vorgänger == ' ' && buchstabe != '\r' && buchstabe != '\n' || buchstabe != '\r' && buchstabe != '\n' && buchstabe != ' ' && vorgänger == '\n')
					wörter++;
				if (buchstabe != ' ' && buchstabe != '\r' && buchstabe != '\n')
					zeichen++;
				if (buchstabe < 'A' && buchstabe != '\r' && buchstabe != '\n' && buchstabe != 'ß'|| buchstabe > 'Z' && buchstabe != '\r' && buchstabe != '\n' && buchstabe != 'ß')
					sonderzeichen++;
				vorgänger = buchstabe;
			}
			analyse.AnzahlVokale = vokale;
			analyse.Buchstaben = buchstabenZahlen;
			analyse.AnzahlZeichen = zeichen;
			analyse.AnzahlWörter = wörter;
			analyse.Sonderzeichen = sonderzeichen;

			txtOutAnalyse.Lines = analyse.ToStringArray();
		}
	}
}
