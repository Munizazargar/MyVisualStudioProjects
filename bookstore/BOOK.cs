using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    sealed public class BOOK : LIBRARY
    {
        
        private string AUTHOR;
        private int PAGES;
        public string author
        {
            set { AUTHOR = value; }
            get { return AUTHOR; }
        }
        public int pages
        {
            set { PAGES = value; }
            get { return PAGES; }
        }
    
        public void info(string author,string id , string title,int cost ,int days,int pages )
        {
           Console.WriteLine("AUTHOR NAME = " + author + " ITEM ID ="+ id +" TITLE = " + title + "COST = " + cost +" RETURN DAYS = "+ days +" PAGES = "+ pages);

        }
        
    }
}
