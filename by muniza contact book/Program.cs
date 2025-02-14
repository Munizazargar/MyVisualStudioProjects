using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace by_muniza_contact_book
{
    internal class Program
    {
       static string path = "contacts.txt";
        static void Main(string[] args)
        {
            Console.WriteLine("press 1 to add a contact");
            Console.WriteLine("press 2 to search a contact");
            Console.WriteLine("press 3 to display contact");
            Console.WriteLine("press 4 to delete a contact");
            Console.WriteLine("press 5 to edit a contact");

            int a=int.Parse(Console.ReadLine());

            if (a == 1) 
            {

                add_contact();
            }
            if (a == 2)
            {

                search_contact();
            }
            if (a == 3)
            {

                display_contact();
            }
            /* if (a == 4)
             {

                 delete_contact();
             }*/
            if (a == 5)
            {

                edit_contact();
            }

            void add_contact() 
            {
                Console.WriteLine("enter the contact name");
                string name=Console.ReadLine();

                Console.WriteLine("enter the contact number");
                string num= Console.ReadLine();

                string contact=name+','+num;

                using (StreamWriter sw = new StreamWriter(path,true)) 
                {
                   sw.WriteLine(contact);
                
                }

            }
            void search_contact()
            {

                Console.WriteLine("enter the contact to be searched");
                string d=Console.ReadLine();

                if (File.Exists(path))
                {
                    string[]contacts=File.ReadAllLines(path);
                    foreach (string contact in contacts)
                    {
                        if (contact.StartsWith(d))
                        {
                           
                            string[] formal_view=contact.Split(',');
                            Console.WriteLine("contact name="+ formal_view[0] + "contact number"+formal_view[1]);
                        }
                       
                    }
                }
                else
                {
                    Console.WriteLine("NO CONTACT FOUND");
                }



            }
            void display_contact()
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    string read = File.ReadAllText(path);
                    Console.WriteLine(read);
                }

            }

            void edit_contact()
            {
                Console.WriteLine("enter the contact that needs to be updated");
                string e=Console.ReadLine();

                if (File.Exists(path))
                {
                    string[] contacts = File.ReadAllLines(path);
                    bool c = false;

                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        foreach (string contact in contacts)
                        {
                            if (contact.StartsWith(e))
                            {
                                c = true;

                                Console.WriteLine("enter the new name");
                                string name = Console.ReadLine();

                                Console.WriteLine("enter the new number");
                                string num = Console.ReadLine();

                                string new_contact=name+" "+num;

                                sw.WriteLine(new_contact);
                                Console.WriteLine($"Contact updated: {new_contact}");
                            }
                            else
                            {
                                sw.WriteLine(contact);
                            }
                            
                        }

                    }
                }


            }
            Console.ReadLine();

        }
    }
}
