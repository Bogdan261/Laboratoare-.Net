using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDesignFirst_L1
{
    class Program
    {
        static void Main(string[] args)
        {
            //testPerson();
            //TestOneToMany();
            TestManyToMany();

        }

        static void testPerson()
        {
            using (Model1Container context= new Model1Container())
            {
                Console.WriteLine("Dati primul nume");
                String firstName = Console.ReadLine();
                Console.WriteLine("Dati numele de mijloc");
                String middleName = Console.ReadLine();
                Console.WriteLine("Dati ultimul nume");
                String lastName = Console.ReadLine();
                Console.WriteLine("Dati numarul de telefon");
                String phoneNumber = Console.ReadLine();
                Person p = new Person()
                {
                    FirstName = firstName,
                    MiddleName = middleName,
                    LastName = lastName,
                    TelephoneNumber = phoneNumber


                };
                context.PersonSet.Add(p);
                context.SaveChanges();
                var items = context.PersonSet;
                foreach (var x in items)
                    Console.WriteLine("{0} {1}", x.Id, x.FirstName);





            }
        }

        static void TestOneToMany()
        {
            using (Model2Container context = new Model2Container())
            {
                Console.WriteLine("Dati numele clientului");
                String name = Console.ReadLine();
                Console.WriteLine("Dati orasul clientului");
                String oras = Console.ReadLine();

                Customer c = new Customer()
                {
                    Name = name,
                    City = oras

                };
                Order o1 = new Order() { TotalValue = 200,  Date = DateTime.Now, Customer = c }; 
                Order o2 = new Order() { TotalValue = 300,  Date = DateTime.Now, Customer = c }; 

                context.CustomerSet.Add(c); 
                context.OrderSet.Add(o1); 
                context.OrderSet.Add(o2);
                context.SaveChanges();

                var items = context.CustomerSet;
                foreach (var x in items)
                { Console.WriteLine("Customer : {0}, {1}, {2}", x.CustomerId, x.Name, x.City); 
                    foreach (var ox in context.OrderSet)
                        Console.WriteLine("\tOrders: {0}, {1}, {2}", ox.OrderId, ox.Date, ox.TotalValue); 
                }



            }

        }

        static void TestManyToMany()
        {

            using (Model3Container c = new Model3Container())
            {
                Album a1 = new Album()
                {
                    AlbumName = "Primul album"

                };
                Album a2 = new Album()
                {
                    AlbumName = "Al doilea album"

                };

                Artist ar1 = new Artist()
                {
                    FirstName = "Dan",
                    LastName = "Balan"

                };
                Artist ar2 = new Artist()
                {
                    FirstName = "Nicu",
                    LastName = "Covaci"

                };
                a1.Artist.Add(ar1);
                a2.Artist.Add(ar2);
                a2.Artist.Add(ar1);
                ar1.Album.Add(a1);
                ar1.Album.Add(a2);

                c.AlbumSet.Add(a1);
                c.AlbumSet.Add(a2);
                c.ArtistSet.Add(ar1);
                c.ArtistSet.Add(ar2);
                c.SaveChanges();
                
                var x = c.ArtistSet;
                foreach( var i in x )
                {
                    Console.WriteLine("{0}" , i.FirstName);
                    foreach (var j in i.Album)
                        Console.WriteLine(j.AlbumName);
                    

                }
                Console.ReadLine();
               
                
                




            }
        }

    }
}
