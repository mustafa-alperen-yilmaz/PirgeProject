using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class movie : Form
    {
        public movie()
        {
            InitializeComponent();
        }
        /*
        private void movies() {
            var client = new RestClient("https://api.collectapi.com/watching/moviesPlaying");
            var request = new RestRequest(Method.Get.ToString());
            request.AddHeader("authorization", "apikey 6A4PQufUad1joAU3R0nYRn:2ntIcxeadez77RSm9SvXvQ");
            request.AddHeader("content-type", "application/json");
            IRestResponse response = client.Execute(request);
            
        }
        */
        private void searchMovieButton_Click(object sender, EventArgs e)
        {
            String movieSearch = searchMovie.Text;
            int itemNo = movieList.Items.IndexOf(movieSearch);
            if (itemNo > -1)
            {
                movieList.SelectedIndex = itemNo;
            }
            else
            {
                MessageBox.Show("Channel Does not exists");
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e)
        {
            if (movieList.SelectedIndex > -1)
            {
                favoriteMovieList.Items.Add(movieList.SelectedItem);
            }
            else
            {
                MessageBox.Show("Must Select The Channel Before Press add favorite");
            }
        }
        /*
        private void movieList_SelectedIndexChanged(object sender, EventArgs e)
        {

            // movieList.Items.Add(movies());
            
        }
        private void movieList_MouseDoubleClick(object sender, EventArgs e) {
            if (movieList.SelectedItem != null)
            {
                MessageBox.Show(movieList.SelectedItem.ToString());
            }

        }
       // rest apilerle hiç çalışmadığım için bu kısmı yetiştiremedim
       // koduma bakıp vakit ayırdığınız için teşekkür ederim
       // olumlu yada olumsuz mailinizi bekliyor olacağım
        */
    }
}
