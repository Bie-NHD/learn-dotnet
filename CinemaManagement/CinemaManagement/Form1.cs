using CinemaManagement.Model;
using System.Diagnostics;

namespace CinemaManagement
{
    public partial class MovieForm : Form
    {
        List<Movie> MovieList = new List<Movie>();

        public MovieForm()
        {
            InitializeComponent();
        }



        private void MovieForm_Load(object sender, EventArgs e)
        {
            MovieList.Add(new Movie("D01", "Avengers",  new DateTime(2019, 4, 26),Constants.ACTIONS, Constants.M_3D,18,0,"Mỹ"));
            MovieList.Add(new Movie("D02", "Tiệc trăng máu", Constants.ROMANCE, new DateTime(2020, 10, 30)));
            MovieList.Add(new Movie("D03", "Lật mặt", Constants.ROMANCE, new DateTime(2019, 4, 12)));

            updateListView();


        }







        private void btnAdd_Click(object sender, EventArgs e)
        {

            Movie movie = new Movie(txtOrderId.Text, txtMovieName.Text);
           
            if (rad_Actions.Checked == true) { movie.MovieCategory = Constants.ACTIONS; }
            if (rad_Romance.Checked == true) { movie.MovieCategory = Constants.ROMANCE; }
            if (rad_2D.Checked == true) { movie.MovieFormat = Constants.M_2D; }
            if (rad_3D.Checked == true) { movie.MovieFormat = Constants.M_3D; }
            movie.AiringDate = dtpAiringDate.Value;

            int.TryParse(txtRestrictAge.Text, out movie.RestrictAge);
            int.TryParse(txtAdditionalFee.Text, out movie.AdditionalFee);

            MovieList.Add(movie);
            updateListView();

        }

        private void updateListView()
        {
            lvMovieList.Items.Clear();
            foreach (Movie movie in MovieList)
            {
                string[] items = { movie.OrderID, movie.MovieName, movie.MovieCategory, movie.AiringDate.ToShortDateString() };
                lvMovieList.Items.Add(new ListViewItem(items));
            }
        }

        private void txtRestrictAge_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            int.Parse(txtRestrictAge.Text);
        }

        private void lvMovieList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (lvMovieList.SelectedItems.Count > 0)
            {
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;



                string id = lvMovieList.SelectedItems[0].SubItems[0].Text;

                Movie movie = MovieList.ElementAt(MovieList.FindIndex(i => i.OrderID == id));
                showDetails(movie);


            }
            else
            {

                ClearForm(grbMovieDetails);

                btnDelete.Enabled = false;
                btnEdit.Enabled = false;
                btnAdd.Enabled = true;
            }
        }
        private void ClearForm(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox)
                {
                    ((TextBox)c).ResetText();
                }
                if (c is RadioButton)
                {
                    ((RadioButton)c).Checked = false;
                }
                if (c is DateTimePicker)
                {
                    c.ResetText();
                }
                if (c.HasChildren) { ClearForm(c); }
                c.Enabled = true;
            }
        }
        private void showDetails(Movie movie)
        {

            txtOrderId.Text = movie.OrderID;
            txtMovieName.Text = movie.MovieName;
            txtMovieOrigin.Text = movie.MovieOrigin;
            // Movie Category
            switch (movie.MovieCategory)
            {
                case Constants.ACTIONS:
                    {
                        rad_Actions.Checked = true;

                        break;
                    }
                case Constants.ROMANCE:
                    {

                        rad_Romance.Checked = true;
                        break;
                    }
                default: break;
            }
            //
            dtpAiringDate.Value = movie.AiringDate;
            //
            switch (movie.MovieFormat)
            {
                case Constants.M_2D:
                    {
                        rad_2D.Checked = true;

                        break;
                    }
                case Constants.M_3D:
                    {
                        rad_3D.Checked = true;
                        break;
                    }
                default: break;
            }
            //
            txtRestrictAge.Text = movie.RestrictAge.ToString();
            txtAdditionalFee.Text = movie.AdditionalFee.ToString();
        }


    }
}