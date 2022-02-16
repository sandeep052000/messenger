using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonn
{
    
    public class Server
        {


            public char s;


            #region Server_Methods
            public void Register()
            {
                Console.WriteLine("press s to Register");
                Console.WriteLine("press n to Unregister");
                char ch = char.Parse(Console.ReadLine());
                string s = ch.ToString().ToLower();
                switch (s)
                {
                    case 1:
                        Console.WriteLine("Enter your Name and Phone number");
                        give_details();
                        break;
                    case 2:
                        Unregister();
                        break;




                }


            }
            public void give_details()
            {
                Client s1 = new Client();
                s1.registration();
                Console.WriteLine("Registration Successful");
                Console.Read();

            }
            public void Unregister()
            {

            }



        }
        #endregion
        public class user_list
        {
            Dictionary<string, long> cl = new Dictionary<string, long>();
            public void list()
            {


            }
        }
        public class Chat
        {

            #region Messaging Methods

            public void messageoptions()
            {
                Options op = new Options();
                Console.WriteLine("press 1 to view");
                Console.WriteLine("press 2 to mute");
                Console.WriteLine("press 3 to deleteChat");

                int sa = int.Parse(Console.ReadLine());
                switch (sa)
                {
                    case 1:
                        op.view();
                        break;
                    case 2:
                        op.mute();
                        break;
                    case 3:
                        op.deleteChat();
                        break;
                }


            }


        }
}
