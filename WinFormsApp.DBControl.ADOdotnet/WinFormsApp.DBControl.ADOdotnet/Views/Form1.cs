using WinFormsApp.DBControl.ADOdotnet.Models;

namespace WinFormsApp.DBControl.ADOdotnet
{
    public partial class Form1 : Form
    {

        BookstoreContext db = new BookstoreContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Books.Select(b => new {b.BookCode, b.BookName}).ToList();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Book book = new Book()
            {
                BookName = "Undead Unluck",
                BookCode = 
                //db.Genres.Where(genre => genre.GenreName == "Action").Select(genre=>genre.GenreCode).First(),
            };

            db.Books.Add(book);
            db.SaveChanges();

            btnView_Click(sender, e);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow _selectedRow = dataGridView1.Rows[dataGridView1.CurrentRow.Index];

            int _BookCode = Convert.ToInt32(_selectedRow.Cells["BookCode"].Value);

            Book selectedBook = db.Books.Find(_BookCode);

            selectedBook.BookName = _selectedRow.Cells["BookName"].Value.ToString();

            db.SaveChanges();

            btnView_Click(sender, e);


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int _BookCode = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["BookCode"].Value);

            Book selectedBook = db.Books.Where(b=>b.BookCode == _BookCode).FirstOrDefault();

            db.Books.Remove(selectedBook);
            db.SaveChanges();

            btnView_Click(sender, e);
        }


    }
}