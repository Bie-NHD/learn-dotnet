using System;
using System.Collections.Generic;

namespace WinFormsApp.DBControl.ADOdotnet.Models;

public partial class Genre
{
    public int GenreCode { get; set; }

    public string GenreName { get; set; } = null!;

    public virtual ICollection<Book> Books { get; set; } = new List<Book>();
}
