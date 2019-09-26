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

		private List<RichTextBox> whiteCardBoxes;

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			if (Debugger.IsAttached) path = @"C:\Users\halor\source\repos\cardsagainsthumanity\cardsagainsthumanity\cards.xml";
			else path = AppDomain.CurrentDomain.BaseDirectory + @"\cards.xml";

			// Centers the title label at the top middle regardless of display size
			titleLabel.Top = 15;
			titleLabel.Left = (ClientSize.Width - titleLabel.Width) / 2;

			whiteCardBox.SelectionAlignment = HorizontalAlignment.Left;

			whiteCards = GetCards("white");
			blackCards = GetCards("black");

			whiteCardBox.Text = whiteCards[0];

		}

		private List<string> GetCards(string color) {
			List<string> data = new List<string>();
			XmlReader reader = XmlReader.Create(path);
			while (reader.Read()) {
				if ((reader.NodeType == XmlNodeType.Element) && (reader.GetAttribute("color") == color)) {
					string node = reader.GetAttribute("text");
					data.Add(node);
				}
			}
			return data;
		}

		private void SetWhiteCard(int index) {


			if (whiteCards[index] == null) index = 0;
			if(whiteCards[index].Length >= 60) 
		}
	}
}
