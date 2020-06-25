using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace CASE_CONVERTER // Created by: Joshua C. Magoliman
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private string sourceText = "";
        private bool isButtonClicked = false;

        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.ActiveControl = rtxtSourceText;
            DisableAllButtons();
        }

        private void CheckIfAnyButtonIsClicked()
        {
            if (isButtonClicked == true)
            {
                isButtonClicked = false;
                this.ActiveControl = lblSourceText;

            }
        }

        private void CountTheCharacter()
        {
            int count = rtxtSourceText.Text.Length;
            lblCharacterCount.Text = "Character Count: " + Convert.ToString(count);
        }


        private void CountTheWord()
        {
            if (rtxtSourceText.Text == "")
            {
                lblWordCount.Text = "Word Count: 0";
            }
            else
            {
                int a = 0, wordsCounted = 1;
                string sourceText = rtxtSourceText.Text;
                while (a <= sourceText.Length - 1)
                {
                    if (sourceText[a] == ' ' || sourceText[a] == '\n' || sourceText[a] == '\t')
                    {
                        wordsCounted++;
                    }
                    a++;
                }
                lblWordCount.Text = "Word Count: " + wordsCounted;
            }
        }

        private void DisableAllButtons()
        {
            btnSentenceCase.Enabled = false;
            btnUpperCase.Enabled = false;
            btnLowerCase.Enabled = false;
            btnAlternatingCase.Enabled = false;
            btnInverseCase.Enabled = false;
            btnReset.Enabled = false;
            btnCopyToClipboard.Enabled = false;
        }

        private void btnSentenceCase_Click(object sender, EventArgs e)
        {

            string output = sourceText.ToLower();
            rtxtSourceText.Text = output;
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            rtxtSourceText.Text = textInfo.ToTitleCase(rtxtSourceText.Text);
            isButtonClicked = true;
            CheckIfAnyButtonIsClicked();
        }

        private void btnUpperCase_Click(object sender, EventArgs e)
        {
            string output = sourceText.ToUpper();
            rtxtSourceText.Text = output;
            isButtonClicked = true;
            CheckIfAnyButtonIsClicked();
        }

        private void btnLowerCase_Click(object sender, EventArgs e)
        {

            string output = sourceText.ToLower();
            rtxtSourceText.Text = output;
            isButtonClicked = true;
            CheckIfAnyButtonIsClicked();
        }

        private void btnAlternatingCase_Click(object sender, EventArgs e)
        {

            string output = string.Concat(
                sourceText.ToLower().AsEnumerable().Select((c, i) => i % 2 == 0 ? c : char.ToUpper(c)));
            rtxtSourceText.Text = output;
            isButtonClicked = true;
            CheckIfAnyButtonIsClicked();
        }

        private void btnInverseCase_Click(object sender, EventArgs e)
        {

            string output = string.Concat(
                sourceText.ToUpper().AsEnumerable().Select((c, i) => i % 2 == 0 ? c : char.ToLower(c)));
            rtxtSourceText.Text = output;
            isButtonClicked = true;
            CheckIfAnyButtonIsClicked();
        }

        private void rtxtSourceText_TextChanged(object sender, EventArgs e)
        {
            sourceText = rtxtSourceText.Text;

            if (rtxtSourceText.Text == "")
            {
                DisableAllButtons();
            }
            else
            {
                btnSentenceCase.Enabled = true;
                btnUpperCase.Enabled = true;
                btnLowerCase.Enabled = true;
                btnAlternatingCase.Enabled = true;
                btnInverseCase.Enabled = true;
                btnReset.Enabled = true;
                btnCopyToClipboard.Enabled = true;
            }

            CountTheCharacter();
            CountTheWord();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtxtSourceText.Text = "";
            lblCharacterCount.Text = "Character Count: 0";
            lblWordCount.Text = "Word Count: 0";
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {

            Clipboard.SetText(rtxtSourceText.Text);
            MessageBox.Show("Successfully copied!", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
