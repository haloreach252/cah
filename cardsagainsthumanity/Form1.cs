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
using System.IO;

namespace cardsagainsthumanity {
	public partial class Form1 : Form {

		private List<string> whiteCards;
		private List<string> blackCards;

		string path = AppDomain.CurrentDomain.BaseDirectory + @"\cards.xml";

		private Button[] whiteCardButtons;
		private List<int> playedCards;

		private Random rand = new Random();

		private Font normalSizeFont = new Font("Arial", 16, FontStyle.Bold);
		private Font smallSizeFont = new Font("Arial", 14, FontStyle.Bold);

		private const int handSize = 7;
		private const int cardTextLengthMod = 70;

		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			//if (Debugger.IsAttached) path = @"C:\Users\halor\source\repos\cardsagainsthumanity\cardsagainsthumanity\cards.xml";
			//if (Debugger.IsAttached) path = @"H:\Coding\C#Projects\cah\cardsagainsthumanity\cards.xml";
			if(Debugger.IsAttached) path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory())) + @"\cards.xml";

			// Centers the title label at the top middle regardless of display size
			titleLabel.Top = 15;
			titleLabel.Left = (ClientSize.Width - titleLabel.Width) / 2;

			whiteCards = GetCards("white");
			blackCards = GetCards("black");

			playedCards = new List<int>();

			Init();
		}

		private void Init() {
			if (whiteCardButtons == null) whiteCardButtons = new Button[7];
			Size s = new Size(170, 220);
			Color fgColor = Color.Black;
			Color bgColor = Color.White;
			Color borderColor = Color.Black;
			Color mouseOverColor = Color.FromArgb(255,240,240,240);
			Color mouseDownColor = ControlPaint.Dark(mouseOverColor);

			Point p = new Point(0, 0);

			for (int i = 0; i < 7; i++) {
				p = new Point((185 * i) + 15, 425);
				Button b = new Button {
					Location = p,
					Size = s,
					TabIndex = i,
					ForeColor = fgColor,
					BackColor = bgColor,
					FlatStyle = FlatStyle.Standard,
					Name = "whiteButton" + i,
				};

				b.FlatAppearance.BorderSize = 4;
				b.FlatAppearance.MouseDownBackColor = mouseDownColor;
				b.FlatAppearance.MouseOverBackColor = mouseOverColor;
				b.Click += WhiteCardClick;

				Controls.Add(b);
				whiteCardButtons[i] = b;
			}
			foreach (Button b in whiteCardButtons) SetWhiteCard(rand.Next(whiteCards.Count), b);
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

		private void SetWhiteCard(int whiteCardIndex, Button box) {
			if (whiteCards[whiteCardIndex] == null) whiteCardIndex = 0;
			if (whiteCards[whiteCardIndex].Length >= cardTextLengthMod) box.Font = smallSizeFont;
			else box.Font = normalSizeFont;

			if (playedCards.Contains(whiteCardIndex) && playedCards.Count + handSize < whiteCards.Count)
				SetWhiteCard(rand.Next(whiteCards.Count), box);
			else if (playedCards.Contains(whiteCardIndex) && playedCards.Count + handSize > whiteCards.Count) {
				playedCards.Clear();
				SetWhiteCard(rand.Next(whiteCards.Count), box);
			} else {
				playedCards.Add(whiteCardIndex);
				box.Text = whiteCards[whiteCardIndex];
			}
		}

		private void WhiteCardClick(object sender, EventArgs e) {
			SetWhiteCard(rand.Next(whiteCards.Count), sender as Button);
		}

		private void button1_Click(object sender, EventArgs e) {
			foreach (Button b in whiteCardButtons) SetWhiteCard(rand.Next(whiteCards.Count), b);
		}
	}
}
