using System;
using System.Collections.Generic;

namespace WinFormsApp.DBControl.ADOdotnet.Models;

public partial class Book
{
    public int BookCode { get; set; }

    public string BookName { get; set; } = null!;

    public int? GenreCode { get; set; }

    public virtual Genre? GenreCodeNavigation { get; set; }
}
