namespace PrimaFereastra
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
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.FileConfirmationLabel = new System.Windows.Forms.Label();
            this.personsCheck = new System.Windows.Forms.CheckedListBox();
            this.insertedPersonBox = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.insertedLocationBox = new System.Windows.Forms.TextBox();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.locationsCheck = new System.Windows.Forms.CheckedListBox();
            this.insertedEventBox = new System.Windows.Forms.TextBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.eventsCheck = new System.Windows.Forms.CheckedListBox();
            this.insertedPropertyBox = new System.Windows.Forms.TextBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.propertysCheck = new System.Windows.Forms.CheckedListBox();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "BrowseFile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "browseFiles";
            // 
            // FileConfirmationLabel
            // 
            this.FileConfirmationLabel.AutoSize = true;
            this.FileConfirmationLabel.Location = new System.Drawing.Point(204, 28);
            this.FileConfirmationLabel.Name = "FileConfirmationLabel";
            this.FileConfirmationLabel.Size = new System.Drawing.Size(54, 13);
            this.FileConfirmationLabel.TabIndex = 1;
            this.FileConfirmationLabel.Text = "File Name";
            this.FileConfirmationLabel.Click += new System.EventHandler(this.FileConfirmation_Click);
            // 
            // personsCheck
            // 
            this.personsCheck.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personsCheck.FormattingEnabled = true;
            this.personsCheck.Location = new System.Drawing.Point(53, 202);
            this.personsCheck.Name = "personsCheck";
            this.personsCheck.Size = new System.Drawing.Size(136, 109);
            this.personsCheck.TabIndex = 2;
            // 
            // insertedPersonBox
            // 
            this.insertedPersonBox.Location = new System.Drawing.Point(53, 147);
            this.insertedPersonBox.Name = "insertedPersonBox";
            this.insertedPersonBox.Size = new System.Drawing.Size(136, 20);
            this.insertedPersonBox.TabIndex = 3;
            this.insertedPersonBox.Text = "Insert Person Name";
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(74, 173);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonButton.TabIndex = 4;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.AddPersonButton_Click);
            // 
            // insertedLocationBox
            // 
            this.insertedLocationBox.Location = new System.Drawing.Point(233, 147);
            this.insertedLocationBox.Name = "insertedLocationBox";
            this.insertedLocationBox.Size = new System.Drawing.Size(144, 20);
            this.insertedLocationBox.TabIndex = 5;
            this.insertedLocationBox.Text = "Insert location name";
            // 
            // addLocationButton
            // 
            this.addLocationButton.Location = new System.Drawing.Point(261, 173);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(83, 23);
            this.addLocationButton.TabIndex = 6;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = true;
            this.addLocationButton.Click += new System.EventHandler(this.AddLocationButton_Click);
            // 
            // locationsCheck
            // 
            this.locationsCheck.FormattingEnabled = true;
            this.locationsCheck.Location = new System.Drawing.Point(233, 202);
            this.locationsCheck.Name = "locationsCheck";
            this.locationsCheck.Size = new System.Drawing.Size(144, 109);
            this.locationsCheck.TabIndex = 7;
            // 
            // insertedEventBox
            // 
            this.insertedEventBox.Location = new System.Drawing.Point(420, 147);
            this.insertedEventBox.Name = "insertedEventBox";
            this.insertedEventBox.Size = new System.Drawing.Size(125, 20);
            this.insertedEventBox.TabIndex = 8;
            this.insertedEventBox.Text = "Insert Event Name";
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(437, 173);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(87, 23);
            this.addEventButton.TabIndex = 9;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // eventsCheck
            // 
            this.eventsCheck.FormattingEnabled = true;
            this.eventsCheck.Location = new System.Drawing.Point(420, 202);
            this.eventsCheck.Name = "eventsCheck";
            this.eventsCheck.Size = new System.Drawing.Size(158, 109);
            this.eventsCheck.TabIndex = 10;
            // 
            // insertedPropertyBox
            // 
            this.insertedPropertyBox.Location = new System.Drawing.Point(640, 146);
            this.insertedPropertyBox.Name = "insertedPropertyBox";
            this.insertedPropertyBox.Size = new System.Drawing.Size(139, 20);
            this.insertedPropertyBox.TabIndex = 11;
            this.insertedPropertyBox.Text = "Insert Aditional Property";
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(664, 172);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(105, 24);
            this.addPropertyButton.TabIndex = 12;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // propertysCheck
            // 
            this.propertysCheck.FormattingEnabled = true;
            this.propertysCheck.Location = new System.Drawing.Point(640, 199);
            this.propertysCheck.Name = "propertysCheck";
            this.propertysCheck.Size = new System.Drawing.Size(144, 109);
            this.propertysCheck.TabIndex = 13;
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Location = new System.Drawing.Point(207, 58);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(47, 13);
            this.FileTypeLabel.TabIndex = 14;
            this.FileTypeLabel.Text = "FileType";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(343, 394);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(126, 30);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 508);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.propertysCheck);
            this.Controls.Add(this.addPropertyButton);
            this.Controls.Add(this.insertedPropertyBox);
            this.Controls.Add(this.eventsCheck);
            this.Controls.Add(this.addEventButton);
            this.Controls.Add(this.insertedEventBox);
            this.Controls.Add(this.locationsCheck);
            this.Controls.Add(this.addLocationButton);
            this.Controls.Add(this.insertedLocationBox);
            this.Controls.Add(this.addPersonButton);
            this.Controls.Add(this.insertedPersonBox);
            this.Controls.Add(this.personsCheck);
            this.Controls.Add(this.FileConfirmationLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "InsertFile";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label FileConfirmationLabel;
        private System.Windows.Forms.CheckedListBox personsCheck;
        private System.Windows.Forms.TextBox insertedPersonBox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox insertedLocationBox;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.CheckedListBox locationsCheck;
        private System.Windows.Forms.TextBox insertedEventBox;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.CheckedListBox eventsCheck;
        private System.Windows.Forms.TextBox insertedPropertyBox;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.CheckedListBox propertysCheck;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.Button saveButton;
    }
}

