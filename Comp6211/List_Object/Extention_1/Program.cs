using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Net;
using System.Diagnostics;

namespace List_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=50");

            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);
            List<CustomObject> malesName = new List<CustomObject>();
            List<CustomObject> femalesName = new List<CustomObject>();
            List<CustomObject> maleAge = new List<CustomObject>();
            List<CustomObject> femalesAge = new List<CustomObject>();


            st.Stop();

            foreach (CustomObject x in data)
            {
                if(x.gender == "female")
                {
                    femalesName.Add(x);
                }
                else
                {
                    malesName.Add(x);
                }
            }
            Console.WriteLine($"There are {femalesName.Count} females and {malesName.Count} males in the dataset downloaded...");

            string[] names = new string[femalesName.Count];
            int counter = 0;
            Console.WriteLine("\n... Original Data ...");
            foreach (CustomObject x in femalesName)
            {
                Console.WriteLine($"\nName: {x.name} {x.surname}\nGender: {x.gender}");
                names[counter] = $"{x.surname}, {x.name}";//Create my own composite key for each person and add to an array
                counter++;
            }

            Array.Sort(names);//Sort my array in alphabetical order
            Console.WriteLine("\n... Sorted array ...");
            foreach (string x in names)
                Console.WriteLine($"Name: {x}");

            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("... Sorting the data ...");

            CustomObject[] females = new CustomObject[femalesName.Count];
            femalesName.CopyTo(females);
            Console.WriteLine(femalesName[0].surname);
            CustomObject[] sortedFemales = new CustomObject[femalesName.Count];
            for (int i = 0; i < females.Length; i++)
            {
                for (int j = 0; j < females.Length; j++)
                {
                    if ($"{females[j].surname}, {females[j].name}" == names[i])
                    {
                        sortedFemales[i] = females[j];
                        Console.WriteLine($"{i}: Person added. {j} internal loops required");
                    }

                }
                Console.WriteLine($"Sorted: {sortedFemales[i].name}\nNames: {names[i]}");
            }

            foreach (CustomObject x in sortedFemales)
            {
                Console.WriteLine($"Name: {x.surname}, {x.name}, {x.birthday.dmy}");
            }

            Console.WriteLine($"Time to populate the list: {st.ElapsedMilliseconds}");
            Console.ReadLine();

            
          
        }
        class CustomObject
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string gender { get; set; }
            public string region { get; set; }
            public int age { get; set; }
            public string title { get; set; }
            public string phone { get; set; }
            public Birthday birthday { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public Credit_Card credit_card{ get; set; }
            public string photo { get; set; }

        }
        class Birthday
        {
            public string dmy { get; set; }
            public string mdy { get; set; }
            public int raw { get; set; }
          
        }
        class Credit_Card
        {
            public string expiration { get; set; }
            public string number { get; set; }
            public int pin { get; set; }
            public int security { get; set; }
          
        }
    }
}
