namespace FereastraModificare
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.propertysCheck = new System.Windows.Forms.CheckedListBox();
            this.addPropertyButton = new System.Windows.Forms.Button();
            this.insertedPropertyBox = new System.Windows.Forms.TextBox();
            this.eventsCheck = new System.Windows.Forms.CheckedListBox();
            this.addEventButton = new System.Windows.Forms.Button();
            this.insertedEventBox = new System.Windows.Forms.TextBox();
            this.locationsCheck = new System.Windows.Forms.CheckedListBox();
            this.addLocationButton = new System.Windows.Forms.Button();
            this.insertedLocationBox = new System.Windows.Forms.TextBox();
            this.addPersonButton = new System.Windows.Forms.Button();
            this.insertedPersonBox = new System.Windows.Forms.TextBox();
            this.personsCheck = new System.Windows.Forms.CheckedListBox();
            this.Delete = new System.Windows.Forms.Button();
            this.FileExists = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(351, 18);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(62, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume Fisier";
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(456, 334);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(137, 32);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save Changes";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // propertysCheck
            // 
            this.propertysCheck.FormattingEnabled = true;
            this.propertysCheck.Location = new System.Drawing.Point(622, 139);
            this.propertysCheck.Name = "propertysCheck";
            this.propertysCheck.Size = new System.Drawing.Size(144, 109);
            this.propertysCheck.TabIndex = 27;
            // 
            // addPropertyButton
            // 
            this.addPropertyButton.Location = new System.Drawing.Point(646, 112);
            this.addPropertyButton.Name = "addPropertyButton";
            this.addPropertyButton.Size = new System.Drawing.Size(105, 24);
            this.addPropertyButton.TabIndex = 26;
            this.addPropertyButton.Text = "Add Property";
            this.addPropertyButton.UseVisualStyleBackColor = true;
            this.addPropertyButton.Click += new System.EventHandler(this.addPropertyButton_Click);
            // 
            // insertedPropertyBox
            // 
            this.insertedPropertyBox.Location = new System.Drawing.Point(622, 86);
            this.insertedPropertyBox.Name = "insertedPropertyBox";
            this.insertedPropertyBox.Size = new System.Drawing.Size(139, 20);
            this.insertedPropertyBox.TabIndex = 25;
            this.insertedPropertyBox.Text = "Insert Aditional Property";
            // 
            // eventsCheck
            // 
            this.eventsCheck.FormattingEnabled = true;
            this.eventsCheck.Location = new System.Drawing.Point(402, 142);
            this.eventsCheck.Name = "eventsCheck";
            this.eventsCheck.Size = new System.Drawing.Size(158, 109);
            this.eventsCheck.TabIndex = 24;
            // 
            // addEventButton
            // 
            this.addEventButton.Location = new System.Drawing.Point(419, 113);
            this.addEventButton.Name = "addEventButton";
            this.addEventButton.Size = new System.Drawing.Size(87, 23);
            this.addEventButton.TabIndex = 23;
            this.addEventButton.Text = "Add Event";
            this.addEventButton.UseVisualStyleBackColor = true;
            this.addEventButton.Click += new System.EventHandler(this.addEventButton_Click);
            // 
            // insertedEventBox
            // 
            this.insertedEventBox.Location = new System.Drawing.Point(402, 87);
            this.insertedEventBox.Name = "insertedEventBox";
            this.insertedEventBox.Size = new System.Drawing.Size(125, 20);
            this.insertedEventBox.TabIndex = 22;
            this.insertedEventBox.Text = "Insert Event Name";
            // 
            // locationsCheck
            // 
            this.locationsCheck.FormattingEnabled = true;
            this.locationsCheck.Location = new System.Drawing.Point(215, 142);
            this.locationsCheck.Name = "locationsCheck";
            this.locationsCheck.Size = new System.Drawing.Size(144, 109);
            this.locationsCheck.TabIndex = 21;
            // 
            // addLocationButton
            // 
            this.addLocationButton.Location = new System.Drawing.Point(243, 113);
            this.addLocationButton.Name = "addLocationButton";
            this.addLocationButton.Size = new System.Drawing.Size(83, 23);
            this.addLocationButton.TabIndex = 20;
            this.addLocationButton.Text = "Add Location";
            this.addLocationButton.UseVisualStyleBackColor = true;
            this.addLocationButton.Click += new System.EventHandler(this.addLocationButton_Click);
            // 
            // insertedLocationBox
            // 
            this.insertedLocationBox.Location = new System.Drawing.Point(215, 87);
            this.insertedLocationBox.Name = "insertedLocationBox";
            this.insertedLocationBox.Size = new System.Drawing.Size(144, 20);
            this.insertedLocationBox.TabIndex = 19;
            this.insertedLocationBox.Text = "Insert location name";
            // 
            // addPersonButton
            // 
            this.addPersonButton.Location = new System.Drawing.Point(56, 113);
            this.addPersonButton.Name = "addPersonButton";
            this.addPersonButton.Size = new System.Drawing.Size(75, 23);
            this.addPersonButton.TabIndex = 18;
            this.addPersonButton.Text = "Add Person";
            this.addPersonButton.UseVisualStyleBackColor = true;
            this.addPersonButton.Click += new System.EventHandler(this.addPersonButton_Click_1);
            // 
            // insertedPersonBox
            // 
            this.insertedPersonBox.Location = new System.Drawing.Point(35, 87);
            this.insertedPersonBox.Name = "insertedPersonBox";
            this.insertedPersonBox.Size = new System.Drawing.Size(136, 20);
            this.insertedPersonBox.TabIndex = 17;
            this.insertedPersonBox.Text = "Insert Person Name";
            // 
            // personsCheck
            // 
            this.personsCheck.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personsCheck.FormattingEnabled = true;
            this.personsCheck.Location = new System.Drawing.Point(35, 142);
            this.personsCheck.Name = "personsCheck";
            this.personsCheck.Size = new System.Drawing.Size(136, 109);
            this.personsCheck.TabIndex = 16;
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(215, 333);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(125, 33);
            this.Delete.TabIndex = 29;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // FileExists
            // 
            this.FileExists.AutoSize = true;
            this.FileExists.Location = new System.Drawing.Point(335, 281);
            this.FileExists.Name = "FileExists";
            this.FileExists.Size = new System.Drawing.Size(64, 13);
            this.FileExists.TabIndex = 30;
            this.FileExists.Text = "File still exits";
            this.FileExists.Click += new System.EventHandler(this.FileExists_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(475, 281);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(75, 23);
            this.ViewButton.TabIndex = 31;
            this.ViewButton.Text = "View File";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.FileExists);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.saveButton);
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
            this.Controls.Add(this.nameLabel);
            this.Name = "Form1";
            this.Text = "Edit File";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckedListBox propertysCheck;
        private System.Windows.Forms.Button addPropertyButton;
        private System.Windows.Forms.TextBox insertedPropertyBox;
        private System.Windows.Forms.CheckedListBox eventsCheck;
        private System.Windows.Forms.Button addEventButton;
        private System.Windows.Forms.TextBox insertedEventBox;
        private System.Windows.Forms.CheckedListBox locationsCheck;
        private System.Windows.Forms.Button addLocationButton;
        private System.Windows.Forms.TextBox insertedLocationBox;
        private System.Windows.Forms.Button addPersonButton;
        private System.Windows.Forms.TextBox insertedPersonBox;
        private System.Windows.Forms.CheckedListBox personsCheck;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Label FileExists;
        private System.Windows.Forms.Button ViewButton;
    }
}

