using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Diagnostics;

namespace cardsagainsthumanity {
	public partial class Form1 : Form {

		private List<string> whiteCards;
		private List<string> blackCards;

		string path = AppDomain.CurrentDomain.BaseDirectory + @"\cards.xml";

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			//if (Debugger.IsAttached && Environment.MachineName == "") path = "";

			// Centers the title label at the top middle regardless of display size
			titleLabel.Top = 15;
			titleLabel.Left = (ClientSize.Width - titleLabel.Width) / 2;

			//whiteCards = GetCards("white");
			//blackCards = GetCards("black");
		}

		private List<string> GetCards(string color) {
			List<string> data = new List<string>();
			//XmlReader reader = XmlReader.Create();
			return data;
		}

		private void tempButton_Click(object sender, EventArgs e) {

		}
	}
}
