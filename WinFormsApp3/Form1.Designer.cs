
namespace WinFormsApp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWzr = new System.Windows.Forms.TextBox();
            this.radK = new System.Windows.Forms.RadioButton();
            this.radM = new System.Windows.Forms.RadioButton();
            this.checkStd = new System.Windows.Forms.CheckBox();
            this.checkIde = new System.Windows.Forms.CheckBox();
            this.Waga = new System.Windows.Forms.Label();
            this.btnObl = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(108, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Podaj wzrost [cm]";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(108, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz płeć";
            // 
            // txtWzr
            // 
            this.txtWzr.Location = new System.Drawing.Point(245, 58);
            this.txtWzr.Name = "txtWzr";
            this.txtWzr.Size = new System.Drawing.Size(125, 27);
            this.txtWzr.TabIndex = 2;
            // 
            // radK
            // 
            this.radK.AutoSize = true;
            this.radK.Location = new System.Drawing.Point(245, 153);
            this.radK.Name = "radK";
            this.radK.Size = new System.Drawing.Size(82, 24);
            this.radK.TabIndex = 3;
            this.radK.TabStop = true;
            this.radK.Text = "Kobieta";
            this.radK.UseVisualStyleBackColor = true;
            // 
            // radM
            // 
            this.radM.AutoSize = true;
            this.radM.Location = new System.Drawing.Point(396, 153);
            this.radM.Name = "radM";
            this.radM.Size = new System.Drawing.Size(102, 24);
            this.radM.TabIndex = 4;
            this.radM.TabStop = true;
            this.radM.Text = "Mężczyzna";
            this.radM.UseVisualStyleBackColor = true;
            // 
            // checkStd
            // 
            this.checkStd.AutoSize = true;
            this.checkStd.Location = new System.Drawing.Point(245, 249);
            this.checkStd.Name = "checkStd";
            this.checkStd.Size = new System.Drawing.Size(119, 24);
            this.checkStd.TabIndex = 5;
            this.checkStd.Text = "Standardowa";
            this.checkStd.UseVisualStyleBackColor = true;
            // 
            // checkIde
            // 
            this.checkIde.AutoSize = true;
            this.checkIde.Location = new System.Drawing.Point(396, 249);
            this.checkIde.Name = "checkIde";
            this.checkIde.Size = new System.Drawing.Size(80, 24);
            this.checkIde.TabIndex = 6;
            this.checkIde.Text = "Idealna";
            this.checkIde.UseVisualStyleBackColor = true;
            // 
            // Waga
            // 
            this.Waga.AutoSize = true;
            this.Waga.Location = new System.Drawing.Point(108, 249);
            this.Waga.Name = "Waga";
            this.Waga.Size = new System.Drawing.Size(47, 20);
            this.Waga.TabIndex = 7;
            this.Waga.Text = "Waga";
            // 
            // btnObl
            // 
            this.btnObl.Location = new System.Drawing.Point(108, 347);
            this.btnObl.Name = "btnObl";
            this.btnObl.Size = new System.Drawing.Size(172, 55);
            this.btnObl.TabIndex = 8;
            this.btnObl.Text = "Oblicz";
            this.btnObl.UseVisualStyleBackColor = true;
            this.btnObl.Click += new System.EventHandler(this.btnObl_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(434, 347);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(370, 55);
            this.txtResult.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Wynik";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(485, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 55);
            this.button1.TabIndex = 11;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnObl);
            this.Controls.Add(this.Waga);
            this.Controls.Add(this.checkIde);
            this.Controls.Add(this.checkStd);
            this.Controls.Add(this.radM);
            this.Controls.Add(this.radK);
            this.Controls.Add(this.txtWzr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Wynik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWzr;
        private System.Windows.Forms.RadioButton radK;
        private System.Windows.Forms.RadioButton radM;
        private System.Windows.Forms.CheckBox checkStd;
        private System.Windows.Forms.CheckBox checkIde;
        private System.Windows.Forms.Label Waga;
        private System.Windows.Forms.Button btnObl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button button1;
    }
}

