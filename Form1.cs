using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace excuseMaker
{
    public partial class excuseMaker : Form
    {
        public excuseMaker()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sentence1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int test = rnd.Next(placeToStoreSentences.firstSentence.Length);
            int best = rnd.Next(placeToStoreSentences.secondSentence.Length);

            sentence1.Text = placeToStoreSentences.firstSentence[test];
            sentence2.Text = placeToStoreSentences.secondSentence[best];
        }

        private void sentence2_Click(object sender, EventArgs e)
        {

        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sentence1.Text + " " + sentence2.Text);
        }
    }
}
