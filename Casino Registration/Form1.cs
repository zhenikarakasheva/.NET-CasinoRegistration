using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
// F120859 - Жени Каракашева
namespace Casino_Registration
{
    public partial class Form1 : Form
    {

        private List<Player> players = new List<Player>();

        public Form1()
        {
            InitializeComponent();
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            //reads the username and the names given by the user
            string playerusername = username.Text;
            string playernames = names.Text;
            //tries to get an integer value for the age; if not successful or age is less than 18, returns an error message
            if (!int.TryParse(age.Text, out int plrage) || int.TryParse(age.Text, out int underage) && underage < 18 )
            {
                MessageBox.Show("This is not a valid age for a casino!");
                return;
            }

            // if there's an existing player with the same username, returns a message
            if (players.Any(p => p.Username == playerusername))
            {
                MessageBox.Show("This player has already joined the casino!");
                return;
            }

            //creates a new player and adds it to the list, as well as to the list box
            Player p = new Player(playerusername, playernames, plrage);
            players.Add(p);

            listBox1.Items.Add(p.ToString());

            // sets the fields clear once work is done
            username.Clear();
            names.Clear();
            age.Clear();
        }
    }
}
