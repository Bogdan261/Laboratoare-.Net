namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNumber = new System.Windows.Forms.TextBox();
            this.Buton1 = new System.Windows.Forms.Button();
            this.Buton2 = new System.Windows.Forms.Button();
            this.Buton3 = new System.Windows.Forms.Button();
            this.Buton4 = new System.Windows.Forms.Button();
            this.Buton5 = new System.Windows.Forms.Button();
            this.Buton6 = new System.Windows.Forms.Button();
            this.Buton7 = new System.Windows.Forms.Button();
            this.Buton8 = new System.Windows.Forms.Button();
            this.Buton9 = new System.Windows.Forms.Button();
            this.Buton0 = new System.Windows.Forms.Button();
            this.Coma = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Inmultit = new System.Windows.Forms.Button();
            this.Impartit = new System.Windows.Forms.Button();
            this.Egal = new System.Windows.Forms.Button();
            this.Negative = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Result
            // 
            this.Result.Location = new System.Drawing.Point(656, 90);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(157, 20);
            this.Result.TabIndex = 7;
            this.Result.TextChanged += new System.EventHandler(this.Result_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(653, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Rezultat";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FirstNumber
            // 
            this.FirstNumber.Location = new System.Drawing.Point(157, 38);
            this.FirstNumber.Name = "FirstNumber";
            this.FirstNumber.Size = new System.Drawing.Size(307, 20);
            this.FirstNumber.TabIndex = 1;
            this.FirstNumber.TextChanged += new System.EventHandler(this.FirstNumber_TextChanged);
            // 
            // Buton1
            // 
            this.Buton1.Location = new System.Drawing.Point(262, 119);
            this.Buton1.Name = "Buton1";
            this.Buton1.Size = new System.Drawing.Size(135, 68);
            this.Buton1.TabIndex = 12;
            this.Buton1.Text = "1";
            this.Buton1.UseVisualStyleBackColor = true;
            this.Buton1.Click += new System.EventHandler(this.Buton1_Click);
            // 
            // Buton2
            // 
            this.Buton2.Location = new System.Drawing.Point(403, 119);
            this.Buton2.Name = "Buton2";
            this.Buton2.Size = new System.Drawing.Size(135, 68);
            this.Buton2.TabIndex = 13;
            this.Buton2.Text = "2";
            this.Buton2.UseVisualStyleBackColor = true;
            this.Buton2.Click += new System.EventHandler(this.Buton2_Click);
            // 
            // Buton3
            // 
            this.Buton3.Location = new System.Drawing.Point(544, 119);
            this.Buton3.Name = "Buton3";
            this.Buton3.Size = new System.Drawing.Size(135, 68);
            this.Buton3.TabIndex = 14;
            this.Buton3.Text = "3";
            this.Buton3.UseVisualStyleBackColor = true;
            this.Buton3.Click += new System.EventHandler(this.Buton3_Click);
            // 
            // Buton4
            // 
            this.Buton4.Location = new System.Drawing.Point(262, 190);
            this.Buton4.Name = "Buton4";
            this.Buton4.Size = new System.Drawing.Size(135, 68);
            this.Buton4.TabIndex = 15;
            this.Buton4.Text = "4";
            this.Buton4.UseVisualStyleBackColor = true;
            this.Buton4.Click += new System.EventHandler(this.Buton4_Click);
            // 
            // Buton5
            // 
            this.Buton5.Location = new System.Drawing.Point(403, 190);
            this.Buton5.Name = "Buton5";
            this.Buton5.Size = new System.Drawing.Size(135, 71);
            this.Buton5.TabIndex = 16;
            this.Buton5.Text = "5";
            this.Buton5.UseVisualStyleBackColor = true;
            this.Buton5.Click += new System.EventHandler(this.Buton5_Click);
            // 
            // Buton6
            // 
            this.Buton6.Location = new System.Drawing.Point(544, 193);
            this.Buton6.Name = "Buton6";
            this.Buton6.Size = new System.Drawing.Size(135, 68);
            this.Buton6.TabIndex = 17;
            this.Buton6.Text = "6";
            this.Buton6.UseVisualStyleBackColor = true;
            this.Buton6.Click += new System.EventHandler(this.Buton6_Click);
            // 
            // Buton7
            // 
            this.Buton7.Location = new System.Drawing.Point(262, 264);
            this.Buton7.Name = "Buton7";
            this.Buton7.Size = new System.Drawing.Size(135, 68);
            this.Buton7.TabIndex = 18;
            this.Buton7.Text = "7";
            this.Buton7.UseVisualStyleBackColor = true;
            this.Buton7.Click += new System.EventHandler(this.Buton7_Click);
            // 
            // Buton8
            // 
            this.Buton8.Location = new System.Drawing.Point(403, 267);
            this.Buton8.Name = "Buton8";
            this.Buton8.Size = new System.Drawing.Size(135, 68);
            this.Buton8.TabIndex = 19;
            this.Buton8.Text = "8";
            this.Buton8.UseVisualStyleBackColor = true;
            this.Buton8.Click += new System.EventHandler(this.Buton8_Click);
            // 
            // Buton9
            // 
            this.Buton9.Location = new System.Drawing.Point(544, 267);
            this.Buton9.Name = "Buton9";
            this.Buton9.Size = new System.Drawing.Size(135, 68);
            this.Buton9.TabIndex = 20;
            this.Buton9.Text = "9";
            this.Buton9.UseVisualStyleBackColor = true;
            this.Buton9.Click += new System.EventHandler(this.Buton9_Click);
            // 
            // Buton0
            // 
            this.Buton0.Location = new System.Drawing.Point(403, 341);
            this.Buton0.Name = "Buton0";
            this.Buton0.Size = new System.Drawing.Size(135, 68);
            this.Buton0.TabIndex = 21;
            this.Buton0.Text = "0";
            this.Buton0.UseVisualStyleBackColor = true;
            this.Buton0.Click += new System.EventHandler(this.Buton0_Click);
            // 
            // Coma
            // 
            this.Coma.Location = new System.Drawing.Point(544, 341);
            this.Coma.Name = "Coma";
            this.Coma.Size = new System.Drawing.Size(135, 68);
            this.Coma.TabIndex = 22;
            this.Coma.Text = ",";
            this.Coma.UseVisualStyleBackColor = true;
            this.Coma.Click += new System.EventHandler(this.Coma_Click);
            // 
            // Plus
            // 
            this.Plus.Location = new System.Drawing.Point(80, 134);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(100, 45);
            this.Plus.TabIndex = 23;
            this.Plus.Text = "Plus";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.Plus_Click);
            // 
            // Minus
            // 
            this.Minus.Location = new System.Drawing.Point(80, 185);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(100, 45);
            this.Minus.TabIndex = 24;
            this.Minus.Text = "Minus";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.Minus_Click);
            // 
            // Inmultit
            // 
            this.Inmultit.Location = new System.Drawing.Point(80, 236);
            this.Inmultit.Name = "Inmultit";
            this.Inmultit.Size = new System.Drawing.Size(100, 45);
            this.Inmultit.TabIndex = 25;
            this.Inmultit.Text = "Inmultit";
            this.Inmultit.UseVisualStyleBackColor = true;
            this.Inmultit.Click += new System.EventHandler(this.Inmultit_Click);
            // 
            // Impartit
            // 
            this.Impartit.Location = new System.Drawing.Point(80, 287);
            this.Impartit.Name = "Impartit";
            this.Impartit.Size = new System.Drawing.Size(100, 45);
            this.Impartit.TabIndex = 26;
            this.Impartit.Text = "Impartit";
            this.Impartit.UseVisualStyleBackColor = true;
            this.Impartit.Click += new System.EventHandler(this.Impartit_Click);
            // 
            // Egal
            // 
            this.Egal.Location = new System.Drawing.Point(262, 341);
            this.Egal.Name = "Egal";
            this.Egal.Size = new System.Drawing.Size(135, 68);
            this.Egal.TabIndex = 27;
            this.Egal.Text = "=";
            this.Egal.UseVisualStyleBackColor = true;
            this.Egal.Click += new System.EventHandler(this.Egal_Click);
            // 
            // Negative
            // 
            this.Negative.Location = new System.Drawing.Point(685, 341);
            this.Negative.Name = "Negative";
            this.Negative.Size = new System.Drawing.Size(128, 68);
            this.Negative.TabIndex = 28;
            this.Negative.Text = "-";
            this.Negative.UseVisualStyleBackColor = true;
            this.Negative.Click += new System.EventHandler(this.Negative_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(685, 119);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(135, 68);
            this.Clear.TabIndex = 29;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 471);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Negative);
            this.Controls.Add(this.Egal);
            this.Controls.Add(this.Impartit);
            this.Controls.Add(this.Inmultit);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.Coma);
            this.Controls.Add(this.Buton0);
            this.Controls.Add(this.Buton9);
            this.Controls.Add(this.Buton8);
            this.Controls.Add(this.Buton7);
            this.Controls.Add(this.Buton6);
            this.Controls.Add(this.Buton5);
            this.Controls.Add(this.Buton4);
            this.Controls.Add(this.Buton3);
            this.Controls.Add(this.Buton2);
            this.Controls.Add(this.Buton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.FirstNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNumber;
        private System.Windows.Forms.Button Buton1;
        private System.Windows.Forms.Button Buton2;
        private System.Windows.Forms.Button Buton3;
        private System.Windows.Forms.Button Buton4;
        private System.Windows.Forms.Button Buton5;
        private System.Windows.Forms.Button Buton6;
        private System.Windows.Forms.Button Buton7;
        private System.Windows.Forms.Button Buton8;
        private System.Windows.Forms.Button Buton9;
        private System.Windows.Forms.Button Buton0;
        private System.Windows.Forms.Button Coma;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Inmultit;
        private System.Windows.Forms.Button Impartit;
        private System.Windows.Forms.Button Egal;
        private System.Windows.Forms.Button Negative;
        private System.Windows.Forms.Button Clear;
    }
}

