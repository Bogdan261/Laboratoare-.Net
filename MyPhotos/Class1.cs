using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MyPhotos
{
    public class Class1
    {
        public static int insertFiles(string fileName, string filePath, string fileType,DateTime creation , List<string> personNames,List<string> locationNames,List<string> eventNames, List<string> propertys)

        {
            using (Model1Container context = new Model1Container())
            {
                bool exista = false;
                var files = context.FisiereSet;
                foreach (var i in files)
                    if (i.Nume == fileName && i.Path == filePath)
                    {
                        exista = true;
                        break;

                    }             
           
                if (!exista &&fileName!="")
                {
                    Fisiere f = new Fisiere()
                    {
                        Nume = fileName,
                        Path = filePath,
                        Tip = fileType,
                        DataCreare = creation,


                    };

                    var persons = context.PersoaneSet;
                    var locations = context.LocatiiSet;
                    var events = context.EvenimenteSet;
                    var property = context.AtributeSet;


                    foreach (string i in personNames)
                        if(i!=null)
                    {                       
                        exista = false;
                        foreach (var j in persons)
                            if (j.Nume == i)
                            {
                                exista = true;
                                j.Fisiere.Add(f);
                                break;
                            }


                        if (!exista)
                        {
                            Persoane p = new Persoane()
                            {
                                Nume = i

                            };
                            p.Fisiere.Add(f);
                            context.PersoaneSet.Add(p);

                        }
                        

                    }

                    foreach (string i in locationNames)
                        if (i != null)
                        {
                        exista = false;

                        foreach (var j in locations)
                            if (j.Nume == i)
                            {
                                exista = true;
                                j.Fisiere.Add(f);
                                break;
                            }


                        if (!exista)
                        {
                            Locatii l = new Locatii()
                            {
                                Nume = i

                            };
                            l.Fisiere.Add(f);
                            context.LocatiiSet.Add(l);

                        }

                    }
                    foreach (string i in eventNames)
                        if (i != null)
                        {
                        exista = false;

                        foreach (var j in events)
                            if (j.Nume == i)
                            {
                                exista = true;
                                j.Fisiere.Add(f);
                                break;
                            }


                        if (!exista)
                        {
                            Evenimente e = new Evenimente()
                            {
                                Nume = i

                            };
                            e.Fisiere.Add(f);
                            context.EvenimenteSet.Add(e);

                        }

                    }

                    foreach (string i in propertys)
                        if (i != null)
                        {
                        exista = false;

                        foreach (var j in property)
                            if (j.Name == i)
                            {
                                exista = true;
                                j.Fisiere.Add(f);
                                break;
                            }


                        if (!exista)
                        {
                            Atribute a = new Atribute()
                            {
                                Name = i

                            };
                            a.Fisiere.Add(f);
                            context.AtributeSet.Add(a);

                        }

                    }
                    
            
                    context.FisiereSet.Add(f);
                    context.SaveChanges();
                    
                    return 1;


                }
                else 
                    return -1;


            }


        }

        public static void modifyFiles(string fileName, string filePath, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys)
        {
           using (Model1Container context = new Model1Container())
            {
                var fisiere = context.FisiereSet;
                foreach (var k in fisiere)
                 if (k.Nume==fileName && k.Path==filePath)
                {
                        k.Locatii.Clear();
                        k.Evenimente.Clear();
                        k.Atribute.Clear();
                        k.Persoane.Clear();

                        break;

                 }                    

               context.SaveChanges();
            }
            using (Model1Container context = new Model1Container())
            {
                var fisiere = context.FisiereSet;
                foreach (var k in fisiere)
                    if (k.Nume == fileName && k.Path == filePath)
                    {                    

                        bool exista;
                        var persons = context.PersoaneSet;
                        var locations = context.LocatiiSet;
                        var events = context.EvenimenteSet;
                        var property = context.AtributeSet;

                        foreach (string i in personNames)
                            if (i != null)
                            {
                                exista = false;

                                foreach (var j in persons)
                                    if (j.Nume == i)
                                    {
                                        exista = true;
                                        j.Fisiere.Add(k);
                                        break;
                                    }


                                if (!exista)
                                {
                                    Persoane p = new Persoane()
                                    {
                                        Nume = i

                                    };
                                    p.Fisiere.Add(k);
                                    context.PersoaneSet.Add(p);

                                }

                            }

                        foreach (string i in locationNames)
                            if (i != null)
                            {
                                exista = false;

                                foreach (var j in locations)
                                    if (j.Nume == i)
                                    {
                                        exista = true;
                                        j.Fisiere.Add(k);
                                        break;
                                    }


                                if (!exista)
                                {
                                    Locatii l = new Locatii()
                                    {
                                        Nume = i

                                    };
                                    l.Fisiere.Add(k);
                                    context.LocatiiSet.Add(l);

                                }

                            }
                        foreach (string i in eventNames)
                            if (i != null)
                            {
                                exista = false;

                                foreach (var j in events)
                                    if (j.Nume == i)
                                    {
                                        exista = true;
                                        j.Fisiere.Add(k);
                                        break;
                                    }


                                if (!exista)
                                {
                                    Evenimente e = new Evenimente()
                                    {
                                        Nume = i

                                    };
                                    e.Fisiere.Add(k);
                                    context.EvenimenteSet.Add(e);

                                }

                            }

                        foreach (string i in propertys)
                            if (i != null)
                            {
                                exista = false;

                                foreach (var j in property)
                                    if (j.Name == i)
                                    {
                                        exista = true;
                                        j.Fisiere.Add(k);
                                        break;
                                    }


                                if (!exista)
                                {
                                    Atribute a = new Atribute()
                                    {
                                        Name = i

                                    };
                                    a.Fisiere.Add(k);
                                    context.AtributeSet.Add(a);

                                }

                            }

                        break;

                    }
                context.SaveChanges();
            }

        }

        public static void deleteFiles(string fileName,string filePath)
        {
            using(Model1Container context= new Model1Container())
            {
                var fisiere = context.FisiereSet;
             
                foreach ( var i in fisiere)
                    if (i.Nume == fileName && i.Path== filePath)
                {

                        i.Atribute.Clear();
                        i.Locatii.Clear();
                        i.Evenimente.Clear();
                        i.Persoane.Clear();

                        context.FisiereSet.Remove(i);
                    
                        break;

                }
                context.SaveChanges();


            }

        }
        public static List<string> getPersons()
        {
            using (Model1Container controler = new Model1Container())
            {
                List<string> persoane = new List<string>();
                var items = controler.PersoaneSet;
                foreach (var i in items)
                    persoane.Add(i.Nume);
                return persoane;
                


            }




        }
        public static List<string> getLocations()
        {
            using (Model1Container controler = new Model1Container())
            {
                List<string> locatii = new List<string>();
                var items = controler.LocatiiSet;
                foreach (var i in items)
                    locatii.Add(i.Nume);
                return locatii;



            }




        }
        public static List<string> getEvents()
        {
            using (Model1Container controler = new Model1Container())
            {
                List<string> evenimente = new List<string>();
                var items = controler.EvenimenteSet;
                foreach (var i in items)
                    evenimente.Add(i.Nume);
                return evenimente;



            }




        }
        public static List<string> getPropertys()
        {
            using (Model1Container controler = new Model1Container())
            {
                List<string> atribute = new List<string>();
                var items = controler.AtributeSet;
                foreach (var i in items)
                    atribute.Add(i.Name);
                return atribute;



            }




        }

        public static List<string> getFilesPath()

        {
            using (Model1Container controler = new Model1Container())
            {
                List<string> fisiere = new List<string>();
                var items = controler.FisiereSet;
                foreach (var i in items)
                    fisiere.Add(i.Path);
                return fisiere;



            }



        }

        public static List<string> getFileDetails( string path)
        {
            using(Model1Container context= new Model1Container())
            {
                List<string> details = new List<string>();
                var fisiere = context.FisiereSet;
                foreach (var i in fisiere)
                if (i.Path== path)
                    {
                        Fisiere f = i;
                        details.Add(f.Nume);
                        details.Add(f.Path);
                        details.Add(f.Tip);
                        details.Add(f.DataCreare.ToString());
                        details.Add("locatii");
                        foreach (var j in f.Locatii)
                            details.Add(j.Nume);
                        details.Add("persoane");
                        foreach (var j in f.Persoane)
                            details.Add(j.Nume);
                        details.Add("evenimente");
                        foreach (var j in f.Evenimente)
                            details.Add(j.Nume);
                        details.Add("props");
                     
                        foreach (var j in f.Atribute)
                            details.Add(j.Name);

                        break;


                    }
                return details;
            }

        }

        public static bool checkedMatch( Fisiere i, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys)
        {
            bool gasitPersoane = true;
            foreach (var j in personNames)
                if(j!=null)
            {
                gasitPersoane = false;
                foreach (var k in i.Persoane)
                    if (k.Nume == j)
                    {
                        gasitPersoane = true;
                        break;

                    }
                if (gasitPersoane == false)
                    break;

            }
            bool gasitEvenimente = true;
            foreach (var j in eventNames)
                if (j != null)
                {
                gasitEvenimente = false;
                foreach (var k in i.Evenimente)
                    if (k.Nume == j)
                    {
                        gasitEvenimente = true;
                        break;

                    }
                if (gasitEvenimente == false)
                    break;

            }
            bool gasitLocatii = true;
            foreach (var j in locationNames)
                if (j != null)
                {
                gasitLocatii = false;
                foreach (var k in i.Locatii)
                    if (k.Nume == j)
                    {
                        gasitLocatii = true;
                        break;

                    }
                if (gasitLocatii == false)
                    break;

            }
            bool gasitPropietati = true;
            foreach (var j in propertys)
                if (j != null)
                {
                gasitPropietati = false;
                foreach (var k in i.Atribute)
                    if (k.Name == j)
                    {
                        gasitPropietati = true;
                        break;

                    }
                if (gasitPropietati == false)
                    break;

            }

            if (gasitPersoane && gasitPropietati && gasitEvenimente && gasitLocatii)
                return true;
            else
                return false;

        }

        public static List<string> searchFile(string fileName, string filePath, string fileType, DateTime creation,bool searchDate, List<string> personNames, List<string> locationNames, List<string> eventNames, List<string> propertys)
        {
            using (Model1Container context = new Model1Container())
            {
                var files = context.FisiereSet;

                Fisiere f=new Fisiere();
                foreach (var i in files)
                    if (i.Path == filePath)
                    {
                        f = i;
                        break;
                    }

                bool hasName=true;
                if (fileName != "")
                    if (!f.Nume.Contains(fileName))
                        hasName = false;

                bool hasPropertys = checkedMatch(f, personNames, locationNames, eventNames, propertys);

                bool hasDate = true;
                if (searchDate)
                    if (!(f.DataCreare.Day == creation.Day && f.DataCreare.Month == creation.Month && f.DataCreare.Year == creation.Year))
                        hasDate = false;
                bool type=true;
                if (fileType != "")
                    if (f.Tip != fileType)
                        type = false;
                if (hasName && hasPropertys && hasDate && type)
                {
                    List<string> details = getFileDetails(filePath);
                    return details;
                }



                List<string> rezultat = new List<string>();
                rezultat.Add("Negasit");
                return rezultat;






            }


        }


    }
   
}
