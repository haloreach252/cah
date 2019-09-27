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

		private List<RichTextBox> whiteCardBoxes;
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
			if(Debugger.IsAttached) path = Path.GetDirectoryName(Path.GetDirectoryName(Directory.GetCurrentDirectory()));

			// Centers the title label at the top middle regardless of display size
			titleLabel.Top = 15;
			titleLabel.Left = (ClientSize.Width - titleLabel.Width) / 2;

			whiteCards = GetCards("white");
			blackCards = GetCards("black");

			playedCards = new List<int>();

			InitializeCards();
			InitializeButtons();
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

		private void InitializeCards() {
			if (whiteCardBoxes == null) whiteCardBoxes = new List<RichTextBox>();
			for (int i = 0; i < 8; i++) {
				Point p = new Point((185 * (i-1)) + 15, 425); Size s = new Size(170, 220);
				RichTextBox b = new RichTextBox {
					Location = p, Size = s,
					ReadOnly = true,
					Font = normalSizeFont
				};

				Controls.Add(b);
				whiteCardBoxes.Add(b);
			}
			foreach (RichTextBox b in whiteCardBoxes) SetWhiteCard(rand.Next(whiteCards.Count), b);
		}

		private void InitializeButtons() {
			Size s = new Size(170, 220); Color c = Color.FromArgb(0,255,255,255);
			for (int i = 0; i < 8; i++) {
				Point p = new Point((185 * (i - 1)) + 15, 425);
				Button button = new Button {
					Location = p,
					Size = s,
					TabIndex = 0,
					UseVisualStyleBackColor = true,
					ForeColor = c,
					BackColor = c,
					FlatStyle = FlatStyle.Flat,
					Name = "WHITE_BUTTON_" + i
				};
				button.FlatAppearance.BorderSize = 0;
				button.FlatAppearance.MouseDownBackColor = c;
				button.FlatAppearance.MouseOverBackColor = c;

				button.Click += WhiteCardClick;
				Controls.Add(button);

				button.BringToFront();
			}
		}

		private void SetWhiteCard(int whiteCardIndex, RichTextBox box) {
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
			MessageBox.Show("CLICKED A FUCKING BUTTON");
		}

		private void button1_Click(object sender, EventArgs e) {
			foreach (RichTextBox b in whiteCardBoxes) SetWhiteCard(rand.Next(whiteCards.Count), b);
		}
	}
}
