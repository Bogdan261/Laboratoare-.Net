namespace FereastraPrincipala
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
            this.Insert = new System.Windows.Forms.Button();
            this.FileGrid = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCreare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Locatii = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Persoane = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Evenimente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Atribute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modifica = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Filter = new System.Windows.Forms.Button();
            this.propertysCheck = new System.Windows.Forms.CheckedListBox();
            this.eventsCheck = new System.Windows.Forms.CheckedListBox();
            this.locationsCheck = new System.Windows.Forms.CheckedListBox();
            this.personsCheck = new System.Windows.Forms.CheckedListBox();
            this.DateFilter = new System.Windows.Forms.DateTimePicker();
            this.Refresh = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.CheckBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.PersonsLabel = new System.Windows.Forms.Label();
            this.LocationsLabel = new System.Windows.Forms.Label();
            this.EventsLabel = new System.Windows.Forms.Label();
            this.OtherLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FileGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // Insert
            // 
            this.Insert.Location = new System.Drawing.Point(12, 27);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(112, 23);
            this.Insert.TabIndex = 0;
            this.Insert.Text = "Insert Data";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // FileGrid
            // 
            this.FileGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FileGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Path,
            this.Tip,
            this.DataCreare,
            this.Locatii,
            this.Persoane,
            this.Evenimente,
            this.Atribute,
            this.Modifica});
            this.FileGrid.Location = new System.Drawing.Point(12, 153);
            this.FileGrid.Name = "FileGrid";
            this.FileGrid.Size = new System.Drawing.Size(1215, 405);
            this.FileGrid.TabIndex = 2;
            this.FileGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FileGrid_CellContentClick);
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            this.Nume.ReadOnly = true;
            // 
            // Path
            // 
            this.Path.HeaderText = "Path";
            this.Path.Name = "Path";
            this.Path.ReadOnly = true;
            this.Path.Width = 50;
            // 
            // Tip
            // 
            this.Tip.HeaderText = "Tip";
            this.Tip.Name = "Tip";
            this.Tip.ReadOnly = true;
            this.Tip.Width = 50;
            // 
            // DataCreare
            // 
            this.DataCreare.HeaderText = "DataCreare";
            this.DataCreare.Name = "DataCreare";
            this.DataCreare.ReadOnly = true;
            // 
            // Locatii
            // 
            this.Locatii.HeaderText = "Locatii";
            this.Locatii.Name = "Locatii";
            this.Locatii.ReadOnly = true;
            this.Locatii.Width = 200;
            // 
            // Persoane
            // 
            this.Persoane.HeaderText = "Persoane";
            this.Persoane.Name = "Persoane";
            this.Persoane.ReadOnly = true;
            this.Persoane.Width = 200;
            // 
            // Evenimente
            // 
            this.Evenimente.HeaderText = "Evenimente";
            this.Evenimente.Name = "Evenimente";
            this.Evenimente.ReadOnly = true;
            this.Evenimente.Width = 200;
            // 
            // Atribute
            // 
            this.Atribute.HeaderText = "Atribute";
            this.Atribute.Name = "Atribute";
            this.Atribute.ReadOnly = true;
            this.Atribute.Width = 200;
            // 
            // Modifica
            // 
            this.Modifica.HeaderText = "Modifica";
            this.Modifica.Name = "Modifica";
            this.Modifica.ReadOnly = true;
            this.Modifica.Width = 50;
            // 
            // Filter
            // 
            this.Filter.Location = new System.Drawing.Point(218, 26);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(99, 23);
            this.Filter.TabIndex = 3;
            this.Filter.Text = "Filter Data";
            this.Filter.UseVisualStyleBackColor = true;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // propertysCheck
            // 
            this.propertysCheck.FormattingEnabled = true;
            this.propertysCheck.Location = new System.Drawing.Point(767, 211);
            this.propertysCheck.Name = "propertysCheck";
            this.propertysCheck.Size = new System.Drawing.Size(144, 109);
            this.propertysCheck.TabIndex = 31;
            // 
            // eventsCheck
            // 
            this.eventsCheck.FormattingEnabled = true;
            this.eventsCheck.Location = new System.Drawing.Point(548, 211);
            this.eventsCheck.Name = "eventsCheck";
            this.eventsCheck.Size = new System.Drawing.Size(158, 109);
            this.eventsCheck.TabIndex = 30;
            // 
            // locationsCheck
            // 
            this.locationsCheck.FormattingEnabled = true;
            this.locationsCheck.Location = new System.Drawing.Point(361, 211);
            this.locationsCheck.Name = "locationsCheck";
            this.locationsCheck.Size = new System.Drawing.Size(144, 109);
            this.locationsCheck.TabIndex = 29;
            // 
            // personsCheck
            // 
            this.personsCheck.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.personsCheck.FormattingEnabled = true;
            this.personsCheck.Location = new System.Drawing.Point(181, 211);
            this.personsCheck.Name = "personsCheck";
            this.personsCheck.Size = new System.Drawing.Size(136, 109);
            this.personsCheck.TabIndex = 28;
            // 
            // DateFilter
            // 
            this.DateFilter.Location = new System.Drawing.Point(464, 30);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(200, 20);
            this.DateFilter.TabIndex = 32;
            // 
            // Refresh
            // 
            this.Refresh.Location = new System.Drawing.Point(444, 58);
            this.Refresh.Name = "Refresh";
            this.Refresh.Size = new System.Drawing.Size(75, 23);
            this.Refresh.TabIndex = 33;
            this.Refresh.Text = "Back";
            this.Refresh.UseVisualStyleBackColor = true;
            this.Refresh.Click += new System.EventHandler(this.Refresh_Click);
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(350, 56);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 26);
            this.Search.TabIndex = 34;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(464, 92);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 35;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(358, 95);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(54, 13);
            this.NameLabel.TabIndex = 36;
            this.NameLabel.Text = "File Name";
            // 
            // DateBox
            // 
            this.DateBox.AutoSize = true;
            this.DateBox.Location = new System.Drawing.Point(705, 31);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(143, 17);
            this.DateBox.TabIndex = 39;
            this.DateBox.Text = "Search By Creation Date";
            this.DateBox.UseVisualStyleBackColor = true;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(362, 132);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(50, 13);
            this.TypeLabel.TabIndex = 38;
            this.TypeLabel.Text = "File Type";
            this.TypeLabel.Click += new System.EventHandler(this.TypeLabel_Click);
            // 
            // TypeBox
            // 
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Imagine",
            "Video"});
            this.TypeBox.Location = new System.Drawing.Point(464, 129);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(123, 21);
            this.TypeBox.TabIndex = 37;
            // 
            // PersonsLabel
            // 
            this.PersonsLabel.AutoSize = true;
            this.PersonsLabel.Location = new System.Drawing.Point(215, 195);
            this.PersonsLabel.Name = "PersonsLabel";
            this.PersonsLabel.Size = new System.Drawing.Size(45, 13);
            this.PersonsLabel.TabIndex = 40;
            this.PersonsLabel.Text = "Persons";
            // 
            // LocationsLabel
            // 
            this.LocationsLabel.AutoSize = true;
            this.LocationsLabel.Location = new System.Drawing.Point(403, 195);
            this.LocationsLabel.Name = "LocationsLabel";
            this.LocationsLabel.Size = new System.Drawing.Size(53, 13);
            this.LocationsLabel.TabIndex = 41;
            this.LocationsLabel.Text = "Locations";
            // 
            // EventsLabel
            // 
            this.EventsLabel.AutoSize = true;
            this.EventsLabel.Location = new System.Drawing.Point(585, 195);
            this.EventsLabel.Name = "EventsLabel";
            this.EventsLabel.Size = new System.Drawing.Size(40, 13);
            this.EventsLabel.TabIndex = 42;
            this.EventsLabel.Text = "Events";
            // 
            // OtherLabel
            // 
            this.OtherLabel.AutoSize = true;
            this.OtherLabel.Location = new System.Drawing.Point(790, 195);
            this.OtherLabel.Name = "OtherLabel";
            this.OtherLabel.Size = new System.Drawing.Size(80, 13);
            this.OtherLabel.TabIndex = 43;
            this.OtherLabel.Text = "Other Propertys";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 643);
            this.Controls.Add(this.OtherLabel);
            this.Controls.Add(this.EventsLabel);
            this.Controls.Add(this.LocationsLabel);
            this.Controls.Add(this.PersonsLabel);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Refresh);
            this.Controls.Add(this.DateFilter);
            this.Controls.Add(this.propertysCheck);
            this.Controls.Add(this.eventsCheck);
            this.Controls.Add(this.locationsCheck);
            this.Controls.Add(this.personsCheck);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FileGrid);
            this.Controls.Add(this.Insert);
            this.Name = "Form1";
            this.Text = "FereastraPrincipala";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FileGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.DataGridView FileGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Path;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCreare;
        private System.Windows.Forms.DataGridViewTextBoxColumn Locatii;
        private System.Windows.Forms.DataGridViewTextBoxColumn Persoane;
        private System.Windows.Forms.DataGridViewTextBoxColumn Evenimente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Atribute;
        private System.Windows.Forms.DataGridViewButtonColumn Modifica;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.CheckedListBox propertysCheck;
        private System.Windows.Forms.CheckedListBox eventsCheck;
        private System.Windows.Forms.CheckedListBox locationsCheck;
        private System.Windows.Forms.CheckedListBox personsCheck;
        private System.Windows.Forms.DateTimePicker DateFilter;
        private System.Windows.Forms.Button Refresh;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.CheckBox DateBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.Label PersonsLabel;
        private System.Windows.Forms.Label LocationsLabel;
        private System.Windows.Forms.Label EventsLabel;
        private System.Windows.Forms.Label OtherLabel;
    }
}

