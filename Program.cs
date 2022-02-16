using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Handsonn
{
    class Program
    {
        public static void Main(string[] args)
        {
            server s = new server();
            Client c = new Client();
            Option op = new Options();
            contact_list l = new contact_list();

            Console.WriteLine("Enter 1 to add");
            Console.WriteLine("Enter 2 to view");
            Console.WriteLine("Enter 3 to edit");
            Console.WriteLine("Enter 4 to delete");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    op.Add();
                    break;
                case 2:
                    op.view();
                    break;
                case 3:
                    op.edit();
                    break;
                case 4:
                    op.delete();
                    break;
            }
    }
}
