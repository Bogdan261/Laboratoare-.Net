using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ViewPhoto;

namespace FereastraModificare
{
    public partial class Form1 : Form
    {
        public string path = "", name = "";
        List<string> locationNames = new List<string>();
        List<string> personNames = new List<string>();
        List<string> eventNames = new List<string>();
        List<string> property = new List<string>();

        public Form1(string name, string path)
        {
            this.path = path;
            this.name = name;
            InitializeComponent();

        }
        private static string[] convertList(List<string> str)
        {
            string[] rezultat = new string[str.Capacity+1];
            int k = 0;
            foreach (var i in str)
            {
                rezultat[k] = i;
                k++;
            }
            return rezultat;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ViewButton.Hide();
            nameLabel.Text = name;
            initialPersons();
            initialLocations();
            initialEvents();
            initialPropertys();
            if (!File.Exists(path))
                FileExists.Text = "This file doesn't exist anymore. We recommend you to delete this record and reupload.";
            else
            {         

              ViewButton.Show();
            }        


        }

        public void initialPersons()
        {
            var obj = new InterfaceMyPhotosClient();
            string[] initialPersons = obj.getPersons();
            foreach (string i in initialPersons)
                this.personsCheck.Items.Add(i);


        }
        public void initialLocations()
        {
            var obj = new InterfaceMyPhotosClient();
            string[] initialLocations = obj.getLocations();
            foreach (string i in initialLocations)
                this.locationsCheck.Items.Add(i);


        }
        public void initialEvents()
        {
            var obj = new InterfaceMyPhotosClient();
            string[] initialEvents = obj.getEvents();
            foreach (string i in initialEvents)
                this.eventsCheck.Items.Add(i);


        }
        public void initialPropertys()
        {
            var obj = new InterfaceMyPhotosClient();
            string[] initialPropertys = obj.getPropertys();
            foreach (string i in initialPropertys)
                this.propertysCheck.Items.Add(i);


        }
      

        private void addPersonButton_Click_1(object sender, EventArgs e)
        {
            string content = insertedPersonBox.Text.Trim();
            if (!personsCheck.Items.Contains(content))
                personsCheck.Items.Add(content, true);

        }

        private void addLocationButton_Click(object sender, EventArgs e)
        {
            string content = insertedLocationBox.Text.Trim();
            if (!locationsCheck.Items.Contains(content))

                locationsCheck.Items.Add(insertedLocationBox.Text, true);

        }

        private void addEventButton_Click(object sender, EventArgs e)
        {
            string content = insertedEventBox.Text.Trim();
            if (!eventsCheck.Items.Contains(content))

                eventsCheck.Items.Add(insertedEventBox.Text, true);

        }

        private void addPropertyButton_Click(object sender, EventArgs e)
        {
            string content = insertedPropertyBox.Text.Trim();
            if (!propertysCheck.Items.Contains(content))

                propertysCheck.Items.Add(insertedPropertyBox.Text, true);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var i in personsCheck.CheckedItems)
                personNames.Add(i.ToString());
            foreach (var i in locationsCheck.CheckedItems)
                locationNames.Add(i.ToString());
            foreach (var i in eventsCheck.CheckedItems)
                eventNames.Add(i.ToString());
            foreach (var i in propertysCheck.CheckedItems)
                property.Add(i.ToString());

            var obj = new InterfaceMyPhotosClient();
            obj.modifyFiles(name, path, convertList(personNames), convertList(locationNames), convertList(eventNames), convertList(property));
            
            this.DialogResult = DialogResult.OK;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            var obj = new InterfaceMyPhotosClient();
            obj.deleteFiles(name, path);
            this.DialogResult = DialogResult.OK;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
          
             new ViewPhoto.Form1(path).ShowDialog();

        }

        private void FileExists_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

      
    }
}
