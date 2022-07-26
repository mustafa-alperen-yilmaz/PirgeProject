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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newChannel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (newChannel.Text != "")
            {
                String channel = newChannel.Text;
                int itemNo = channelListBox.Items.IndexOf(channel);
                if (itemNo == -1)
                {
                    channelListBox.Items.Add(channel);
                    newChannel.Text = "";
                    newChannel.Focus();
                }
                else {
                    MessageBox.Show("Channel Already Exists on list");
                }
            }
            else {
                MessageBox.Show("Please Enter A Channel Name");
            }
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex > -1)
            {
                channelListBox.Items.RemoveAt(channelListBox.SelectedIndex); 
            }
            else
            {
                MessageBox.Show("Must Select The Channel Before Press Remove button");
            }
        }

        

        private void changeChannel_TextChanged(object sender, EventArgs e)
        {

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            String changeChannelName = changeChannel.Text;
            if (channelListBox.SelectedIndex > -1)
            {
                channelListBox.Items[channelListBox.SelectedIndex] = changeChannelName;
            }
            else
            {
                MessageBox.Show("Must Select The Channel Before Press Change button");
            }
            changeChannel.Text = "";
            changeChannel.Focus();
        }

        private void searchChannelButton_Click(object sender, EventArgs e)
        {
            String channelSearch = serachChannel.Text;
            int itemNo = channelListBox.Items.IndexOf(channelSearch);
            if (itemNo > -1)
            {
                channelListBox.SelectedIndex = itemNo;
            }
            else {
                MessageBox.Show("Channel Does not exists");
            }
        }

        private void makeFavoriteButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex > -1) {
                favoriteChannelListBox.Items.Add(channelListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Must Select The Channel Before Press add favorite");
            }


        }

        private void removeFromFavoriteButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex > -1)
            {
                favoriteChannelListBox.Items.RemoveAt(favoriteChannelListBox.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Must Select The Channel Before Press Remove button");
            }
        }

        private void soundOnButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sound is opened");
        }

        private void soundOfButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sound is closed");
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex > -1)
            {
                int index = channelListBox.SelectedIndex;
                string listBoxText = channelListBox.SelectedItem.ToString();
                if (index > 0) {
                    channelListBox.Items.RemoveAt(index);
                    channelListBox.Items.Insert(index - 1, channelListBox);
                    channelListBox.SetSelected(index - 1, true);
                }
            }
            else {
                MessageBox.Show("Select a channel please");
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex > -1)
            {
                int index = channelListBox.SelectedIndex;
                string listBoxText = channelListBox.SelectedItem.ToString();
                if (index < channelListBox.Items.Count-1)
                {
                    channelListBox.Items.RemoveAt(index);
                    channelListBox.Items.Insert(index + 1, channelListBox);
                    channelListBox.SetSelected(index + 1, true);
                }
            }
            else
            {
                MessageBox.Show("Select a channel please");
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            if (channelListBox.SelectedIndex > -1)
            {
                string listBoxText = channelListBox.SelectedItem.ToString();
                MessageBox.Show(listBoxText + " channel opened ");
            }
            else {
                MessageBox.Show("Select a channel please");
            }
            }

        private void movieButton_Click(object sender, EventArgs e)
        {
            movie moove = new movie();
            moove.Show();
        }

       
    }
}
 