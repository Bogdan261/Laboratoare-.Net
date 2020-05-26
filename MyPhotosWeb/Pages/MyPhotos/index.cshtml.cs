using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyPhotosWeb.Models;
using ServiceReferenceMyPhotos;

namespace MyPhotosWeb.Pages.MyPhotos
{
    public class indexModel : PageModel
    {
        InterfaceMyPhotosClient client = new InterfaceMyPhotosClient();
        public List<string> paths { get; set; }
        public List<FisiereDTO> fisiere;
        public List<AtributeDTO> atribute;
        public List<PersoaneDTO> persoane;
        public List<LocatiiDTO> locatii;
        public List<EvenimenteDTO> evenimente;

        public List<string> persoaneStringList;
        public List<string> atributeStringList;
        public List<string> locatiiStringList;
        public List<string> evenimenteStringList;


        public SelectList persoaneSelect { get; set; }

        [BindProperty(SupportsGet = true)]
        public string persoanaCautata { get; set; }
        [BindProperty(SupportsGet = true)]
        public string locatiaCautata { get; set; }
        [BindProperty(SupportsGet = true)]
        public string evenimentulCautat { get; set; }
        [BindProperty(SupportsGet = true)]
        public string atributulCautat { get; set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }

        public int numarRezultate;
      

        public indexModel()
        {
            paths = new List<string>();
            fisiere = new List<FisiereDTO>();
            atribute = new List<AtributeDTO>();
            persoane = new List<PersoaneDTO>();
            locatii = new List<LocatiiDTO>();
            evenimente = new List<EvenimenteDTO>();           

        }
        
        public void CreateObjects(List<string> details)
        {
            FisiereDTO fisier = new FisiereDTO();
            if (fisiere.Count == 0)
                fisier.IdFisier = 0;
            else
                fisier.IdFisier = fisiere[fisiere.Count() - 1].IdFisier + 1;

            fisier.Nume = details[0];
            fisier.Path = details[1];
            fisier.Tip = details[2];
            fisier.DataCreare = DateTime.Parse(details[3]);

            int value = -1;
            for (int i = 4; i< details.Count;i++)
            {
                if (details[i] == "locatii") value = 1;
                else if (details[i] == "persoane") value = 2;
                else if (details[i] == "evenimente") value = 3;
                else if (details[i] == "props") value = 4;
                else
                {
                    if (value == 1)
                    {
                        foreach (var obj in locatii)
                            if (obj.Nume == details[i])
                            {
                                fisier.Locatii.Add(obj);
                                obj.Fisiere.Add(fisier);
                                break;
                            }
                    }
                    else
                      if (value == 2)
                    {
                        foreach (var obj in persoane)
                            if (obj.Nume == details[i])
                            {
                                fisier.Persoane.Add(obj);
                                obj.Fisiere.Add(fisier);
                                break;
                            }
                    }
                    else 
                    if (value == 3)
                    {
                        foreach (var obj in evenimente)
                            if (obj.Nume == details[i])
                            {
                                fisier.Evenimente.Add(obj);
                                obj.Fisiere.Add(fisier);
                                break;
                            }
                    }
                    else
                      if (value == 4)
                    {
                        foreach (var obj in atribute)
                            if (obj.Name == details[i])
                            {
                                fisier.Atribute.Add(obj);
                                obj.Fisiere.Add(fisier);
                                break;
                            }
                    }
                }
            }
            fisiere.Add(fisier);
        }

        public void CompletePhotos(List<string> paths)
        {
            DirectoryInfo d= new DirectoryInfo(@"C:\Users\Bogdan\Desktop\Proiect3\Laboratoare-.Net-Proiect2\ServerWCF\MyPhotosWeb\wwwroot\Photos");
            FileInfo[] Files = d.GetFiles("."); 
            foreach( var file in Files)
               if(paths.Where(p => p.Contains(file.Name)).ToList().Count == 0 )             
                System.IO.File.Delete(file.FullName);

            Files = d.GetFiles(".");
            foreach (var path in paths)
                if (System.IO.File.Exists(path))
                    if(!System.IO.File.Exists(@"C:\Users\Bogdan\Desktop\Proiect3\Laboratoare-.Net-Proiect2\ServerWCF\MyPhotosWeb\wwwroot\Photos\"+ Path.GetFileName(path)))
                     System.IO.File.Copy(path, @"C:\Users\Bogdan\Desktop\Proiect3\Laboratoare-.Net-Proiect2\ServerWCF\MyPhotosWeb\wwwroot\Photos\" + Path.GetFileName(path));




        }

        public async Task OnGetAsync()
        {
            var returnedPaths =  await client.getFilesPathAsync();
            CompletePhotos(returnedPaths);
            atributeStringList = await client.getPropertysAsync();
            persoaneStringList = await client.getPersonsAsync();
            locatiiStringList = await client.getLocationsAsync();
            evenimenteStringList = await client.getEventsAsync();

            int id = 0;
            foreach (var atributString in atributeStringList)
            {
                AtributeDTO atribut = new AtributeDTO() { IdAtribut = id, Name = atributString };
                atribute.Add(atribut);
                id++;
            }
            id = 0;
            foreach (var persoanaString in persoaneStringList)
            {
                PersoaneDTO persoana = new PersoaneDTO() { IdPersoana = id, Nume = persoanaString };
                persoane.Add(persoana);
                id++;

            }
            id = 0;
            foreach (var locatieString in locatiiStringList)
            {
                LocatiiDTO locatie = new LocatiiDTO() { IdLocatie = id, Nume = locatieString };
                locatii.Add(locatie);
                id++;

            }
            id = 0;
            foreach (var evenimentString in evenimenteStringList)
            {
                EvenimenteDTO eveniment = new EvenimenteDTO() { IdEveniment = id, Nume = evenimentString };
                evenimente.Add(eveniment);
                id++;

            }
            
            foreach (var i in returnedPaths)
            {
                paths.Add(i);
                List<string> fileDetails = new List<string>();
                fileDetails = await client.getFileDetailsAsync(i);

               // foreach (var j in fileDetails)
                  //  paths.Add(j);
                
                CreateObjects(fileDetails);
                

            }
           
                                                    

            SelectList persoaneSelect = new SelectList(persoaneStringList);

            if(!string.IsNullOrEmpty(persoanaCautata))
            {
                List<FisiereDTO> temp = new List<FisiereDTO>();               
                
                foreach (var j in fisiere)
                    if (j.Persoane.Where(p => p.Nume.Contains(persoanaCautata)).Count() != 0)
                        temp.Add(j);                
                fisiere = temp;    

            }
            if (!string.IsNullOrEmpty(locatiaCautata))
            {
                List<FisiereDTO> temp = new List<FisiereDTO>();

                foreach (var j in fisiere)
                    if (j.Locatii.Where(p => p.Nume.Contains(locatiaCautata)).Count() != 0)
                        temp.Add(j);
                fisiere = temp;

            }
            if (!string.IsNullOrEmpty(evenimentulCautat))
            {
                List<FisiereDTO> temp = new List<FisiereDTO>();

                foreach (var j in fisiere)
                    if (j.Evenimente.Where(p => p.Nume.Contains(evenimentulCautat)).Count() != 0)
                        temp.Add(j);
                fisiere = temp;

            }
            if (!string.IsNullOrEmpty(atributulCautat))
            {
                List<FisiereDTO> temp = new List<FisiereDTO>();

                foreach (var j in fisiere)
                    if (j.Atribute.Where(p => p.Name.Contains(atributulCautat)).Count() != 0)
                        temp.Add(j);
                fisiere = temp;

            }
            if (!string.IsNullOrEmpty(SearchString))
            {
                List<FisiereDTO> temp = new List<FisiereDTO>();

                foreach (var j in fisiere)
                    if (j.Nume.Contains(SearchString))
                        temp.Add(j);
                fisiere = temp;

            }

            fisiere = fisiere.OrderBy(o => o.Nume).ToList();

            numarRezultate = fisiere.Count;




        }
    }
}