using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Globalization;
using System.Threading;
using System.Resources;
// F120859 - Жени Каракашева
namespace Casino_Registration
{
    public partial class Form1 : Form
    {
        private List<Player> players = new List<Player>();
        string lang; // for the language

        int cardX = 90;
        int speed = 2;
        System.Windows.Forms.Timer animationTimer;
        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint|ControlStyles.OptimizedDoubleBuffer|ControlStyles.ResizeRedraw|ControlStyles.UserPaint, true);
            gameBoard.Paint += boardGamePaint;
            
            animationTimer = new System.Windows.Forms.Timer();
            animationTimer.Interval = 25; 
            animationTimer.Tick += animation;
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            //reads the username and the names given by the user
            string playerusername = username.Text;
            string playernames = names.Text;
            //tries to get an integer value for the age; if not successful or age is less than 18, returns an error message
            if (!int.TryParse(age.Text, out int plrage) || int.TryParse(age.Text, out int underage) && underage < 18)
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

            playersList.Items.Add(p.ToString());

            // sets the fields clear once work is done
            username.Clear();
            names.Clear();
            age.Clear();
        }

        //a method for changing the language
        public void ChangeLanguage(string lng)
        {
            CultureInfo culture = new CultureInfo(lng);

            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentCulture = culture;

            ComponentResourceManager resources = new ComponentResourceManager(this.GetType());

            this.Text = resources.GetString("$this.Text", culture);

            foreach (Control c in this.Controls)
            {
                resources.ApplyResources(c, c.Name, culture);
                foreach (Control ctr in c.Controls)
                {
                    resources.ApplyResources(ctr, ctr.Name, culture);
                }
            }

            if (this.menuStrip1 != null)
            {
                //a separate method for changing the language on the menu
                ApplyResourcesToMenu(this.menuStrip1, resources, culture);
            }
        }

        private void ApplyResourcesToMenu(MenuStrip menu, ComponentResourceManager resources, CultureInfo culture)
        {
            foreach (ToolStripItem item in menu.Items)
            {
                ApplyResourcesToToolStripItem(item, resources, culture);
            }
        }

        //a helper function to change the language on the menu items
        private void ApplyResourcesToToolStripItem(ToolStripItem item, ComponentResourceManager resources, CultureInfo culture)
        {
            resources.ApplyResources(item, item.Name, culture);

            if (item is ToolStripMenuItem menuItem)
            {
                foreach (ToolStripItem subItem in menuItem.DropDownItems)
                {
                    ApplyResourcesToToolStripItem(subItem, resources, culture);
                }
            }
        }

        //when the user clicks on the Exit button on the menu, the form closes
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //when the user clicks on the English subbutton on the menu, the form changes language to English
        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang = "en-US";
            ChangeLanguage(lang);
        }

        //when the user clicks on the Bulgarian subbutton on the menu, the form changes language to Bulgarian
        private void bulgarianToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lang = "bg-BG";
            ChangeLanguage(lang);
        }


        //when the user clicks on the Show game button on the menu, the form displays a game if such is not already displayed
        private void showGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gameBoard.Visible == false)
            {
                gameBoard.Visible = true;

                gameBoard.Invalidate(); 
                animationTimer.Start();
            }
            else
            {
                gameBoard.Visible = false;
                animationTimer.Stop();
            }

        }

        private void boardGamePaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            //draw an ace and a pope
            DrawCard(g, cardX, 20, "A♠");
            DrawCard(g, cardX + 80, 20, "K♠");
        }

        void DrawCard(Graphics g, int x, int y, string text)
        {
            //a rectangle with 60 width and 90 height
            Rectangle card = new Rectangle(x, y, 60, 90);

            //the rectangle is filled with white paint and has a black border
            g.FillRectangle(Brushes.White, card);
            g.DrawRectangle(Pens.Black, card);

            //the text is written in the upper left corner
            g.DrawString(text, new Font("Arial", 14, FontStyle.Bold), Brushes.Black, x + 10, y + 10);
        }

        //when the user clicks on the Show players button on the menu, the form displays a list of players if such is not already displayed
        private void showPlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (playersList.Visible == false)
            {
                playersList.Visible = true;
            }
            else
            {
                playersList.Visible = false;
            }
        }

        //move of the cards on the board
        private void animation(object sender, EventArgs e)
        {
            cardX += speed;

            // left and right max limits of the card movement
            if (cardX < 10 || cardX + 150 > gameBoard.Width)
            {
                speed = -speed; // shift the direction
            }

            gameBoard.Invalidate(); // redraw
        }
    }
}
