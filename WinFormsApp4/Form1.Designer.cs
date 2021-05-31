
namespace WinFormsApp4
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
            this.txt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radW3 = new System.Windows.Forms.RadioButton();
            this.radW2 = new System.Windows.Forms.RadioButton();
            this.radW1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radPod = new System.Windows.Forms.RadioButton();
            this.radKur = new System.Windows.Forms.RadioButton();
            this.radPog = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radColG = new System.Windows.Forms.RadioButton();
            this.radColB = new System.Windows.Forms.RadioButton();
            this.radColR = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReset2 = new System.Windows.Forms.Button();
            this.btnReset3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(54, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your text";
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(240, 45);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(673, 27);
            this.txt.TabIndex = 1;
            this.txt.Text = "sdasd";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReset);
            this.groupBox1.Controls.Add(this.radW3);
            this.groupBox1.Controls.Add(this.radW2);
            this.groupBox1.Controls.Add(this.radW1);
            this.groupBox1.Location = new System.Drawing.Point(99, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 206);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Font Size";
            // 
            // radW3
            // 
            this.radW3.AutoSize = true;
            this.radW3.Location = new System.Drawing.Point(16, 129);
            this.radW3.Name = "radW3";
            this.radW3.Size = new System.Drawing.Size(52, 24);
            this.radW3.TabIndex = 2;
            this.radW3.TabStop = true;
            this.radW3.Text = "Big";
            this.radW3.UseVisualStyleBackColor = true;
            // 
            // radW2
            // 
            this.radW2.AutoSize = true;
            this.radW2.Location = new System.Drawing.Point(16, 88);
            this.radW2.Name = "radW2";
            this.radW2.Size = new System.Drawing.Size(85, 24);
            this.radW2.TabIndex = 1;
            this.radW2.TabStop = true;
            this.radW2.Text = "Medium";
            this.radW2.UseVisualStyleBackColor = true;
            // 
            // radW1
            // 
            this.radW1.AutoSize = true;
            this.radW1.Location = new System.Drawing.Point(16, 45);
            this.radW1.Name = "radW1";
            this.radW1.Size = new System.Drawing.Size(67, 24);
            this.radW1.TabIndex = 0;
            this.radW1.TabStop = true;
            this.radW1.Text = "Small";
            this.radW1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset2);
            this.groupBox2.Controls.Add(this.radPod);
            this.groupBox2.Controls.Add(this.radKur);
            this.groupBox2.Controls.Add(this.radPog);
            this.groupBox2.Location = new System.Drawing.Point(365, 143);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(185, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Text decoration";
            // 
            // radPod
            // 
            this.radPod.AutoSize = true;
            this.radPod.Location = new System.Drawing.Point(16, 129);
            this.radPod.Name = "radPod";
            this.radPod.Size = new System.Drawing.Size(94, 24);
            this.radPod.TabIndex = 2;
            this.radPod.TabStop = true;
            this.radPod.Text = "Underline";
            this.radPod.UseVisualStyleBackColor = true;
            // 
            // radKur
            // 
            this.radKur.AutoSize = true;
            this.radKur.Location = new System.Drawing.Point(16, 88);
            this.radKur.Name = "radKur";
            this.radKur.Size = new System.Drawing.Size(62, 24);
            this.radKur.TabIndex = 1;
            this.radKur.TabStop = true;
            this.radKur.Text = "Italic";
            this.radKur.UseVisualStyleBackColor = true;
            // 
            // radPog
            // 
            this.radPog.AutoSize = true;
            this.radPog.Location = new System.Drawing.Point(16, 45);
            this.radPog.Name = "radPog";
            this.radPog.Size = new System.Drawing.Size(61, 24);
            this.radPog.TabIndex = 0;
            this.radPog.TabStop = true;
            this.radPog.Text = "Bold";
            this.radPog.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReset3);
            this.groupBox3.Controls.Add(this.radColG);
            this.groupBox3.Controls.Add(this.radColB);
            this.groupBox3.Controls.Add(this.radColR);
            this.groupBox3.Location = new System.Drawing.Point(644, 143);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(185, 222);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Color";
            // 
            // radColG
            // 
            this.radColG.AutoSize = true;
            this.radColG.Location = new System.Drawing.Point(16, 129);
            this.radColG.Name = "radColG";
            this.radColG.Size = new System.Drawing.Size(69, 24);
            this.radColG.TabIndex = 2;
            this.radColG.TabStop = true;
            this.radColG.Text = "Green";
            this.radColG.UseVisualStyleBackColor = true;
            // 
            // radColB
            // 
            this.radColB.AutoSize = true;
            this.radColB.Location = new System.Drawing.Point(16, 88);
            this.radColB.Name = "radColB";
            this.radColB.Size = new System.Drawing.Size(59, 24);
            this.radColB.TabIndex = 1;
            this.radColB.TabStop = true;
            this.radColB.Text = "Blue";
            this.radColB.UseVisualStyleBackColor = true;
            // 
            // radColR
            // 
            this.radColR.AutoSize = true;
            this.radColR.Location = new System.Drawing.Point(16, 45);
            this.radColR.Name = "radColR";
            this.radColR.Size = new System.Drawing.Size(56, 24);
            this.radColR.TabIndex = 0;
            this.radColR.TabStop = true;
            this.radColR.Text = "Red";
            this.radColR.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(508, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(321, 64);
            this.button1.TabIndex = 5;
            this.button1.Text = "Change text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(136, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(32, 34);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "X";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReset2
            // 
            this.btnReset2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset2.Location = new System.Drawing.Point(153, 11);
            this.btnReset2.Name = "btnReset2";
            this.btnReset2.Size = new System.Drawing.Size(32, 34);
            this.btnReset2.TabIndex = 7;
            this.btnReset2.Text = "X";
            this.btnReset2.UseVisualStyleBackColor = true;
            this.btnReset2.Click += new System.EventHandler(this.btnReset2_Click);
            // 
            // btnReset3
            // 
            this.btnReset3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset3.Location = new System.Drawing.Point(153, 11);
            this.btnReset3.Name = "btnReset3";
            this.btnReset3.Size = new System.Drawing.Size(32, 34);
            this.btnReset3.TabIndex = 7;
            this.btnReset3.Text = "X";
            this.btnReset3.UseVisualStyleBackColor = true;
            this.btnReset3.Click += new System.EventHandler(this.btnReset3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 511);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.label1);
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

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radW3;
        private System.Windows.Forms.RadioButton radW2;
        private System.Windows.Forms.RadioButton radW1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radPod;
        private System.Windows.Forms.RadioButton radKur;
        private System.Windows.Forms.RadioButton radPog;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.RadioButton radColR;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radColB;
        private System.Windows.Forms.RadioButton radColG;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReset2;
        private System.Windows.Forms.Button btnReset3;
    }
}

