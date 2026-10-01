namespace Zad_7
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTextF = new Label();
            textBox1 = new TextBox();
            gpbFonts = new GroupBox();
            rbFont3 = new RadioButton();
            rbFont2 = new RadioButton();
            rbFont1 = new RadioButton();
            chkbBold = new CheckBox();
            chkbItalic = new CheckBox();
            gpbFonts.SuspendLayout();
            SuspendLayout();
            // 
            // lblTextF
            // 
            lblTextF.AutoSize = true;
            lblTextF.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            lblTextF.Location = new Point(37, 9);
            lblTextF.Name = "lblTextF";
            lblTextF.Size = new Size(257, 37);
            lblTextF.TabIndex = 0;
            lblTextF.Text = "Въведете текст: ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.Location = new Point(37, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(493, 45);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // gpbFonts
            // 
            gpbFonts.Controls.Add(rbFont3);
            gpbFonts.Controls.Add(rbFont2);
            gpbFonts.Controls.Add(rbFont1);
            gpbFonts.Location = new Point(148, 105);
            gpbFonts.Name = "gpbFonts";
            gpbFonts.Size = new Size(382, 226);
            gpbFonts.TabIndex = 2;
            gpbFonts.TabStop = false;
            gpbFonts.Text = "Fonts";
            // 
            // rbFont3
            // 
            rbFont3.AutoSize = true;
            rbFont3.BackColor = Color.FromArgb(255, 255, 192);
            rbFont3.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbFont3.Location = new Point(34, 150);
            rbFont3.Name = "rbFont3";
            rbFont3.Size = new Size(89, 41);
            rbFont3.TabIndex = 2;
            rbFont3.Text = "Arial";
            rbFont3.UseVisualStyleBackColor = false;
            rbFont3.CheckedChanged += rbFont3_CheckedChanged;
            // 
            // rbFont2
            // 
            rbFont2.AutoSize = true;
            rbFont2.BackColor = Color.FromArgb(255, 192, 128);
            rbFont2.Font = new Font("Courier New", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbFont2.Location = new Point(34, 95);
            rbFont2.Name = "rbFont2";
            rbFont2.Size = new Size(242, 40);
            rbFont2.TabIndex = 1;
            rbFont2.Text = "Courier New";
            rbFont2.UseVisualStyleBackColor = false;
            rbFont2.CheckedChanged += rbFont2_CheckedChanged;
            // 
            // rbFont1
            // 
            rbFont1.AutoSize = true;
            rbFont1.BackColor = Color.FromArgb(128, 255, 128);
            rbFont1.Checked = true;
            rbFont1.Font = new Font("Bookman Old Style", 24F, FontStyle.Regular, GraphicsUnit.Point, 204);
            rbFont1.Location = new Point(34, 40);
            rbFont1.Name = "rbFont1";
            rbFont1.Size = new Size(337, 43);
            rbFont1.TabIndex = 0;
            rbFont1.TabStop = true;
            rbFont1.Text = "Bookman Old Style";
            rbFont1.UseVisualStyleBackColor = false;
            rbFont1.CheckedChanged += rbFont1_CheckedChanged;
            // 
            // chkbBold
            // 
            chkbBold.AutoSize = true;
            chkbBold.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 204);
            chkbBold.Location = new Point(37, 145);
            chkbBold.Name = "chkbBold";
            chkbBold.Size = new Size(104, 49);
            chkbBold.TabIndex = 3;
            chkbBold.Text = "Bold";
            chkbBold.UseVisualStyleBackColor = true;
            chkbBold.CheckedChanged += chkbBold_CheckedChanged;
            // 
            // chkbItalic
            // 
            chkbItalic.AutoSize = true;
            chkbItalic.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point, 204);
            chkbItalic.Location = new Point(37, 200);
            chkbItalic.Name = "chkbItalic";
            chkbItalic.Size = new Size(105, 49);
            chkbItalic.TabIndex = 4;
            chkbItalic.Text = "Italic";
            chkbItalic.UseVisualStyleBackColor = true;
            chkbItalic.CheckedChanged += chkbItalic_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(563, 347);
            Controls.Add(chkbItalic);
            Controls.Add(chkbBold);
            Controls.Add(gpbFonts);
            Controls.Add(textBox1);
            Controls.Add(lblTextF);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Задача 7";
            gpbFonts.ResumeLayout(false);
            gpbFonts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTextF;
        private TextBox textBox1;
        private GroupBox gpbFonts;
        private RadioButton rbFont3;
        private RadioButton rbFont2;
        private RadioButton rbFont1;
        private CheckBox chkbBold;
        private CheckBox chkbItalic;
    }
}
