using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PrimaFereastra
{
    public partial class Form1 : Form
    {
       
        string fileName = "";
        string filePath = "";
        string type = "";
        List<string> locationNames = new List<string>();
        List<string> personNames = new List<string>();
        List<string> eventNames = new List<string>();
        List<string> property = new List<string>();
        DateTime creation;

        private static string[] convertList(List<string> str)
        {
            string[] rezultat = new string[str.Capacity+2];
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
            initialPersons();
            initialLocations();
            initialEvents();
            initialPropertys();

        }



        public  void initialPersons()
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



       

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
          
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.filePath = openFileDialog1.FileName;
               
             

                if (File.Exists(filePath))
                {   string  PhotoExtensions = "All Image files | *.bmp; *.gif, *.jpg, *.ico; " + " *.emf;, .wmf | Bitmap files(.bmp; *.gif; *.jpg; " + " *.ico) | *.bmp; *.gif; *.jpg; *.ico | " + "Meta Files(*.emf; *.wmf; *.png) | *.emf; *.wmf; *.png ; *.PNG";
                    string VideoExtensions = " *.avi , *.m4v , *.mp4, *.mkv";
                   
                    if (PhotoExtensions.Contains(Path.GetExtension(filePath)))
                        this.type = "Imagine";
                    else
                    if (VideoExtensions.Contains(Path.GetExtension(filePath)))
                        this.type = "Video";
                    if (this.type != "")
                    {
                        FileConfirmationLabel.Text = Path.GetFileName(filePath);
                        FileTypeLabel.Text = this.type;
                        this.fileName = Path.GetFileName(filePath);
                        this.creation = File.GetCreationTime(filePath);
                        //Aici Deja avem toate detaliile despre fisier
                       

                    }
                    else
                    {
                        MessageBox.Show("Ati selectat un fisier de tip gresit", "Avertizment", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }
                }

            }


        }

       

        private void FileConfirmation_Click(object sender, EventArgs e)
        {

        }

        private void AddPersonButton_Click(object sender, EventArgs e)
        {
            string content = insertedPersonBox.Text.Trim();
            if (!personsCheck.Items.Contains(content))
             personsCheck.Items.Add(content, true);

        }

        private void AddLocationButton_Click(object sender, EventArgs e)
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
            if(!propertysCheck.Items.Contains(content))

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
            int rezultat =obj.insertFiles(this.fileName, this.filePath,this.type ,this.creation, convertList(this.personNames), convertList(this.locationNames), convertList(this.eventNames), convertList(this.property));

            if (rezultat == -1)
            {
                personNames.Clear();
                locationNames.Clear();
                eventNames.Clear();
                property.Clear();
                MessageBox.Show("Nu s-a inserat nimic, fisierul deja exista. Incercati cu altul sau inchideti fereastra.", "Avertizment", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                this.DialogResult = DialogResult.OK;






        }
    }
}
