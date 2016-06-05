using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();      
        }
        
        /**
        Prepare linklabel on load.
        */
        private void About_Load_1(object sender, EventArgs e)
        {
            LinkLabel.Link link = new LinkLabel.Link();
            link.LinkData = "https://github.com/KamilBest/2048Game";
            linkLabel1.Links.Add(link);
        }

        /**
        Link label on click. Turn on browser with link address.
        */
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        /**
        Close window on button click.
        */
        private void Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
