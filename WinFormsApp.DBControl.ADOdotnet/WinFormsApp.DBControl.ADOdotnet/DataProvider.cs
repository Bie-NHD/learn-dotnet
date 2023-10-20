using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp.DBControl.ADOdotnet.Models;

namespace WinFormsApp.DBControl.ADOdotnet
{
    internal class DataProvider
    {
        BookstoreContext db = new BookstoreContext();

        public BookstoreContext Database { get { return db; } set { db = value; } }
    }
}
