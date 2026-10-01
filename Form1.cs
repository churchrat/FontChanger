namespace Zad_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void UpdateText()
        {
            if (chkbBold.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            if (chkbItalic.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            if (chkbBold.Checked && chkbItalic.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            if (!chkbBold.Checked && !chkbItalic.Checked)
            {
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            }
            if (rbFont1.Checked)
            {
                textBox1.Font = new Font(rbFont1.Font,textBox1.Font.Style);
                textBox1.BackColor = rbFont1.BackColor;
            }
            if (rbFont2.Checked)
            {
                textBox1.Font = new Font(rbFont2.Font, textBox1.Font.Style);
                textBox1.BackColor = rbFont2.BackColor;
            }
            if (rbFont3.Checked)
            {
                textBox1.Font = new Font(rbFont3.Font, textBox1.Font.Style);
                textBox1.BackColor = rbFont3.BackColor;
            }
        }

        private void chkbBold_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void chkbItalic_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void rbFont1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void rbFont2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
        }

        private void rbFont3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateText();
        }
    }
}
