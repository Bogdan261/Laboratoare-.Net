using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimaFereastra;
using FereastraModificare;
namespace FereastraPrincipala
{
    public partial class Form1 : Form
    {
        public static string modificaPath = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (new PrimaFereastra.Form1().ShowDialog() == DialogResult.OK)

            {

    
               
                FileGrid.Rows.Clear();
                FileList();
            }

        }
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

        private string[] getTableRow(string[] rand)
        {
            string[] sir = new string[100];

            int k = 0;
            string content = "";
            bool concat = false;
            foreach (var j in rand)
            {

                if (j == "locatii" || j == "evenimente" || j == "persoane" || j == "props")
                    if (content != "")
                    {
                        sir[k] = content;
                        content = "";
                        k++;
                        continue;

                    }
                    else
                      if (concat == false)
                    { concat = true; content = ""; continue; }
                    else
                       if (concat == true)
                    {
                        sir[k] = "";
                        k++;
                        continue;


                    }

                if (concat == true)
                {
                    content += j;
                    content += " , ";
                }
                else
                {
                    sir[k] = j;
                    k++;
                }

            }
            sir[k] = content;
            return sir;

        }
        
        private void FileList()
        {
            var obj = new InterfaceMyPhotosClient();
            string[] paths = obj.getFilesPath();

            foreach (var i in paths)
            {
                Console.WriteLine("Calea este {0}",i);
                var obj1 = new InterfaceMyPhotosClient();
                string[] rand = obj1.getFileDetails(i);
                for (int j = 0; j < rand.Length; j++)
                    Console.WriteLine("Detaliul este : {0}",rand[j]);
                var sir = getTableRow(rand);
                FileGrid.Rows.Add(sir);



            }




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Search.Hide();
            DateFilter.Hide();
            personsCheck.Hide();
            locationsCheck.Hide();
            propertysCheck.Hide();
            eventsCheck.Hide();
            Refresh.Hide();
            NameLabel.Hide();
            NameBox.Hide();
            TypeBox.Hide();
            TypeLabel.Hide();
            DateBox.Hide();
            PersonsLabel.Hide();
            EventsLabel.Hide();
            OtherLabel.Hide();
            LocationsLabel.Hide();
            FileList();
           
          


        }

        private void FileGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var fileName = FileGrid.Rows[e.RowIndex].Cells[0].Value;
            var filePath = FileGrid.Rows[e.RowIndex].Cells[1].Value;

            if (fileName != null)
            {
                new FereastraModificare.Form1(fileName.ToString(), filePath.ToString()).ShowDialog();
                FileGrid.Rows.Clear();
                FileList();
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
        private void Filter_Click(object sender, EventArgs e)
        {
            FileGrid.Hide();
            Insert.Hide();
            Filter.Hide();
            personsCheck.Show();
            locationsCheck.Show();
            propertysCheck.Show();
            eventsCheck.Show();
            Search.Show();
            NameLabel.Show();
            NameBox.Show();
            TypeBox.Show();
            TypeLabel.Show();
            DateFilter.Show();
            DateBox.Show();
            PersonsLabel.Show();
            EventsLabel.Show();
            OtherLabel.Show();
            LocationsLabel.Show();
            personsCheck.Items.Clear();
            locationsCheck.Items.Clear();
            eventsCheck.Items.Clear();
            propertysCheck.Items.Clear();
            initialPersons();
            initialLocations();
            initialEvents();
            initialPropertys();

        }

        private void Refresh_Click(object sender, EventArgs e)
        {   
            Search.Hide();
            DateFilter.Hide();
            personsCheck.Hide();
            locationsCheck.Hide();
            propertysCheck.Hide();
            eventsCheck.Hide();
            Refresh.Hide();
            Insert.Show();
            FileGrid.Rows.Clear();
            FileGrid.Show();
            NameLabel.Hide();
            NameBox.Hide();
            TypeLabel.Hide();
            TypeBox.Hide();
            DateBox.Hide();
            Filter.Show();
            FileList();

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string nume = NameBox.Text.Trim();
            string tip = TypeBox.Text;
            List<string> propietati = new List<string>();
            List<string> locatii = new List<string>();
            List<string> evenimente = new List<string>();
            List<string> persoane = new List<string>();
            DateTime data = DateFilter.Value;
            personsCheck.Hide();
            Filter.Hide();
            locationsCheck.Hide();
            propertysCheck.Hide();
            eventsCheck.Hide();
            Search.Hide();
            NameLabel.Hide();
            NameBox.Hide();
            TypeBox.Hide();
            TypeLabel.Hide();
            DateFilter.Hide();
            PersonsLabel.Hide();
            EventsLabel.Hide();
            OtherLabel.Hide();
            LocationsLabel.Hide();
            DateBox.Hide();
            Refresh.Show();

            FileGrid.Rows.Clear();
            FileGrid.Show();

            foreach (var i in personsCheck.CheckedItems)
                persoane.Add(i.ToString());
            foreach (var i in locationsCheck.CheckedItems)
                locatii.Add(i.ToString());
            foreach (var i in eventsCheck.CheckedItems)
                evenimente.Add(i.ToString());
            foreach (var i in propertysCheck.CheckedItems)
                propietati.Add(i.ToString());

            bool searchDate = false;
            if (DateBox.Checked)
                searchDate = true;
            var obj = new InterfaceMyPhotosClient();
            string[] paths = obj.getFilesPath();
            foreach (var i in paths)
            {
                string[] rand = new string[1000];
             
                rand = obj.searchFile(nume,i,tip,data,searchDate,convertList(persoane), convertList(locatii), convertList(evenimente), convertList(propietati));
               
                
                if (!rand.Contains("Negasit"))
                {
                    var sir = getTableRow(rand);

                    FileGrid.Rows.Add(sir);
                }
            }
        }

        private void TypeLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
