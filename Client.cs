using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonn
{
    public class Client
    {
        #region Registration Method
        public void registration()
        {
            string name = Console.ReadLine();
            long ph = long.Parse(Console.ReadLine());
        }
        #endregion
    }

    public class contact_list
    {

        List<string> ConList = new List<string>();
        string a = "sandeep";
        string b = "mahesh";
        string c = "abhi varma";
        string d = "mouli chand";

        #region Removing Participants Methods
        public void list()
        {
            ConList.Add(a);
            ConList.Add(b);
            ConList.Add(c);
            ConList.Add(d);
            foreach (string read in ConList)
            {
                Console.WriteLine(read);
            }



        }
        public void RemoveParticipant_sandeep()
        {
            ConList.Remove(a);
            foreach (string read in ConList)
            {
                Console.WriteLine(read);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_mahesh()
        {
            ConList.Remove(b);

            foreach (string read in ConList)
            {
                Console.WriteLine(read);
            }
            Console.ReadLine();

        }
        public void Remove_abhi()
        {
            ConList.Remove(c);
            foreach (string read in ConList)
            {
                Console.WriteLine(read);
            }
            Console.ReadLine();

        }
        public void RemoveParticipant_mouli()
        {
            ConList.Remove(d);
            foreach (string read in ConList)
            {
                Console.WriteLine(read);
            }
            Console.ReadLine();

        }

    }

    public class remove
    {
        public void removing()
        {


            contact_list k = new contact_list();
            k.list();
            Console.WriteLine("press a to remove sandeep");
            Console.WriteLine("press b to remove mahesh");
            Console.WriteLine("press c to remove abhi");
            Console.WriteLine("press d to remove mouli");
            char input = char.Parse(Console.ReadLine());
            string s = input.ToString().ToLower();
            switch (s)
            {
                case "a":
                    L.RemoveParticipant_sandeep();
                    break;
                case "b":
                    l.RemoveParticipant_mahesh();
                    break;
                case "c":
                    l.RemoveParticipant_abhi();
                    break;
                case "d":
                    l.RemoveParticipant_mouli();
                    break;
            }
            Console.WriteLine("contact List after removing participant");
            l.list();
        }

    }
}