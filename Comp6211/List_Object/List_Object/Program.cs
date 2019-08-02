using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Web.Script.Serialization;
using System.Diagnostics;

namespace List_Object
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch st = new Stopwatch();
            st.Start();

            string json = new WebClient().DownloadString("https://uinames.com/api/?ext&amount=10 ");
            
            List<CustomObject> data = new JavaScriptSerializer().Deserialize<List<CustomObject>>(json);

            st.Stop();
   

            foreach(CustomObject x in data)
            {
                Console.WriteLine($"---------------Customer {x.name}----------------");
                Console.WriteLine($"Name: {x.name} {x.surname}\nGender: {x.gender}\nRegion: {x.region}\nAge: {x.age}\nTitle: {x.title}\nPhone: {x.phone}\n\nBirthday:\nDMY: {x.birthday.dmy}\nMDY: {x.birthday.mdy}\nRAW: {x.birthday.dmy}\n\nEmail: {x.email}\nPassword: {x.password}\n\n" +
                    $"\nCredit Card:\nEXP: {x.credit_card.expiration}\nCard Number: {x.credit_card.number}\nPin: {x.credit_card.pin}\nSecurity: {x.credit_card.security}\nPhoto: {x.photo}\n\n");
                
            }
            Console.WriteLine($"Time to populate the list: {st.ElapsedMilliseconds}");
        }
    }
}
