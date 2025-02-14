using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bookstore
{
    abstract public class LIBRARY
    {
        protected string TITLE;
        protected string ITEM_ID;
        protected int COST;
        protected int RETURN_DAYS;
        public string title
        {
            set { TITLE = value; }
            get { return TITLE; }
        }
        public string item_id
        {
            set { ITEM_ID = value; }
            get { return ITEM_ID; }
        }
        public int cost
        {
            set { COST = value; }
            get { return COST; }
        }
        public int return_days
        {
            set { RETURN_DAYS = value; }
            get { return RETURN_DAYS; }
        }
        
        
    }
}
