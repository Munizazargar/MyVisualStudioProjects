using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace CONTACT_BOOK
{
    internal class Program
    {
        static string file = "contacts.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("PRESS 1 TO ADD A CONTACT NO");
            Console.WriteLine("PRESS 2 TO SEARCH ANY CONTACT");
            Console.WriteLine("PRESS 3 TO DISPLAY ALL CONTACTS");
            Console.WriteLine("PRESS 4 TO DELETE A CONTACT");
            Console.WriteLine("PRESS 5 TO UPDATE A CONTACT");
            Console.WriteLine("PRESS 6 TO UPDATE A CONTACT completely");

            int A = int.Parse(Console.ReadLine());
            if (A == 1)
            {
                create_contact();
            }
            if (A == 2)
            {
                search_contact();
            }
            if (A == 3)
            {
                display_contacts();
            }
            if (A == 4)
            {
                delete_contact();
            }
            if (A == 5)
            {
                update_contact();
            }
            if (A == 6)
            {
                nameno();
            }

            Console.ReadLine();
        }
        static void create_contact()
        {
            Console.WriteLine("ENTER THE NAME OF CONTACT NAME ");
            string a = Console.ReadLine();
            Console.WriteLine("ENTER THE CONTACT NUMBER ");
            string b = Console.ReadLine();
            string c = a + "," + b;

            using (StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine(c);

            }



        }
        static void search_contact()
        {
            Console.WriteLine("ENTER THE CONTACT TO BE SEARCHED");
            string d = Console.ReadLine();
            if (File.Exists(file))
            {
                string[] contacts = File.ReadAllLines(file);
                foreach (string contact in contacts)
                {
                    if (contact.StartsWith(d))
                    {
                        string[] formal_view = contact.Split(',');
                        Console.WriteLine("NAME = " + formal_view[0] +
                            "   NUMBER = " + formal_view[1]);

                    }
                }

            }
            else
            {
                Console.WriteLine("NO CONTACT FOUND");
            }

        }
        static void display_contacts()
        {
            try
            {
                using (StreamReader sr = new StreamReader(file))
                {
                    string read = File.ReadAllText(file);
                    Console.WriteLine(read);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("FILE DOES'NT EXIST");
            }
        }
        static void delete_contact()
        {
            Console.WriteLine("ENTER THE CONTACT TO BE DELETED");
            string d = Console.ReadLine();
            string[] contacts = File.ReadAllLines(file);
            int i = 0;
            using (StreamWriter s = new StreamWriter(file))
            {
                for (i = 0; i < contacts.Length; i++)
                {
                    string contact = contacts[i];


                    if (!contact.StartsWith(d))
                    {
                        s.WriteLine(contact);

                    }
                }

            }


        }
        static void update_contact()
        {
            Console.WriteLine("ENTER THE CONTACT TO BE UPDATED");
            string d = Console.ReadLine();

            if (File.Exists(file))
            {
                
                Console.WriteLine("ENTER UPDATED NAME");
                string updated_name = Console.ReadLine();

                string[] contacts = File.ReadAllLines(file);
                using (StreamWriter s = new StreamWriter(file))
                {
                    foreach (string contact in contacts)
                    {
                        if (!contact.StartsWith(d))
                        {
                            s.WriteLine(contact);
                        }
                        else
                        {
                            d = updated_name;
                            s.WriteLine(d);

                        }


                    }
                }
            }
        }
        static void nameno()
        {
            Console.WriteLine("ENTER NO TO BE UPDATED");
            string no = Console.ReadLine();

            if (File.Exists(file))
            {
                Console.WriteLine("ENTER NEW NO");
                string new_no = Console.ReadLine();

                string[] contacts = File.ReadAllLines(file);
                using (StreamWriter sw = new StreamWriter(file))
                {
                    foreach (string contact in contacts)
                    {
                        if (!contact.EndsWith(no))
                        {
                            sw.WriteLine(contact);
                        }
                        else
                        {
                            no = new_no;
                            string[] formal_view = contact.Split(',');
                           // Console.WriteLine( formal_view[0] + formal_view[1]);
                            string updated_contact = formal_view[0] + no;
                            sw.WriteLine( updated_contact);
                            Console.WriteLine(updated_contact);
                        }
                    }
                }
            }

            //finally
            //throwexception
            //blacklistedkeywords
            //is_keyword
        }
    }

}
        
    

