
namespace ZmieniaczKoloru
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radBigger = new System.Windows.Forms.RadioButton();
            this.radBig = new System.Windows.Forms.RadioButton();
            this.radSmall = new System.Windows.Forms.RadioButton();
            this.checkBold = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkCurs = new System.Windows.Forms.CheckBox();
            this.checkUnder = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radBlue = new System.Windows.Forms.RadioButton();
            this.radGreen = new System.Windows.Forms.RadioButton();
            this.radRed = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(371, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tekst";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radBigger);
            this.groupBox1.Controls.Add(this.radBig);
            this.groupBox1.Controls.Add(this.radSmall);
            this.groupBox1.Location = new System.Drawing.Point(80, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(115, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wielkość";
            // 
            // radBigger
            // 
            this.radBigger.AutoSize = true;
            this.radBigger.Location = new System.Drawing.Point(6, 72);
            this.radBigger.Name = "radBigger";
            this.radBigger.Size = new System.Drawing.Size(60, 19);
            this.radBigger.TabIndex = 6;
            this.radBigger.TabStop = true;
            this.radBigger.Text = "b.duża";
            this.radBigger.UseVisualStyleBackColor = true;
            // 
            // radBig
            // 
            this.radBig.AutoSize = true;
            this.radBig.Location = new System.Drawing.Point(6, 47);
            this.radBig.Name = "radBig";
            this.radBig.Size = new System.Drawing.Size(51, 19);
            this.radBig.TabIndex = 5;
            this.radBig.TabStop = true;
            this.radBig.Text = "dużo";
            this.radBig.UseVisualStyleBackColor = true;
            // 
            // radSmall
            // 
            this.radSmall.AutoSize = true;
            this.radSmall.Location = new System.Drawing.Point(6, 22);
            this.radSmall.Name = "radSmall";
            this.radSmall.Size = new System.Drawing.Size(51, 19);
            this.radSmall.TabIndex = 3;
            this.radSmall.TabStop = true;
            this.radSmall.Text = "mała";
            this.radSmall.UseVisualStyleBackColor = true;
            // 
            // checkBold
            // 
            this.checkBold.AutoSize = true;
            this.checkBold.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBold.Location = new System.Drawing.Point(6, 23);
            this.checkBold.Name = "checkBold";
            this.checkBold.Size = new System.Drawing.Size(51, 19);
            this.checkBold.TabIndex = 4;
            this.checkBold.Text = "Bold";
            this.checkBold.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkCurs);
            this.groupBox2.Controls.Add(this.checkUnder);
            this.groupBox2.Controls.Add(this.checkBold);
            this.groupBox2.Location = new System.Drawing.Point(201, 93);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(133, 123);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Styl";
            // 
            // checkCurs
            // 
            this.checkCurs.AutoSize = true;
            this.checkCurs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.checkCurs.Location = new System.Drawing.Point(6, 48);
            this.checkCurs.Name = "checkCurs";
            this.checkCurs.Size = new System.Drawing.Size(71, 19);
            this.checkCurs.TabIndex = 5;
            this.checkCurs.Text = "Kursywa";
            this.checkCurs.UseVisualStyleBackColor = true;
            // 
            // checkUnder
            // 
            this.checkUnder.AutoSize = true;
            this.checkUnder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.checkUnder.Location = new System.Drawing.Point(6, 75);
            this.checkUnder.Name = "checkUnder";
            this.checkUnder.Size = new System.Drawing.Size(93, 19);
            this.checkUnder.TabIndex = 6;
            this.checkUnder.Text = "Podkreślenie";
            this.checkUnder.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radBlue);
            this.groupBox3.Controls.Add(this.radGreen);
            this.groupBox3.Controls.Add(this.radRed);
            this.groupBox3.Location = new System.Drawing.Point(340, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(120, 123);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kolor";
            // 
            // radBlue
            // 
            this.radBlue.AutoSize = true;
            this.radBlue.Location = new System.Drawing.Point(6, 72);
            this.radBlue.Name = "radBlue";
            this.radBlue.Size = new System.Drawing.Size(71, 19);
            this.radBlue.TabIndex = 7;
            this.radBlue.TabStop = true;
            this.radBlue.Text = "niebieski";
            this.radBlue.UseVisualStyleBackColor = true;
            // 
            // radGreen
            // 
            this.radGreen.AutoSize = true;
            this.radGreen.Location = new System.Drawing.Point(6, 48);
            this.radGreen.Name = "radGreen";
            this.radGreen.Size = new System.Drawing.Size(62, 19);
            this.radGreen.TabIndex = 8;
            this.radGreen.TabStop = true;
            this.radGreen.Text = "zielony";
            this.radGreen.UseVisualStyleBackColor = true;
            // 
            // radRed
            // 
            this.radRed.AutoSize = true;
            this.radRed.Location = new System.Drawing.Point(6, 23);
            this.radRed.Name = "radRed";
            this.radRed.Size = new System.Drawing.Size(75, 19);
            this.radRed.TabIndex = 9;
            this.radRed.TabStop = true;
            this.radRed.Text = "czerwony";
            this.radRed.UseVisualStyleBackColor = true;
         
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(188, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 62);
            this.button1.TabIndex = 4;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radBigger;
        private System.Windows.Forms.RadioButton radBig;
        private System.Windows.Forms.RadioButton radSmall;
        private System.Windows.Forms.CheckBox checkBold;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkCurs;
        private System.Windows.Forms.CheckBox checkUnder;
        private System.Windows.Forms.RadioButton radBlue;
        private System.Windows.Forms.RadioButton radGreen;
        private System.Windows.Forms.RadioButton radRed;
        private System.Windows.Forms.Button button1;
    }
}

