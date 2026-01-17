using System.Windows.Forms;

namespace Casino_Registration
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.username = new System.Windows.Forms.TextBox();
            this.names = new System.Windows.Forms.TextBox();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.namesLabel = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.TextBox();
            this.ageLabel = new System.Windows.Forms.Label();
            this.playersList = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.changeLanguageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bulgarianToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPlayersToolstripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameBoard = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // username
            // 
            resources.ApplyResources(this.username, "username");
            this.username.Name = "username";
            // 
            // names
            // 
            resources.ApplyResources(this.names, "names");
            this.names.Name = "names";
            // 
            // buttonAddPlayer
            // 
            resources.ApplyResources(this.buttonAddPlayer, "buttonAddPlayer");
            this.buttonAddPlayer.BackColor = System.Drawing.Color.SeaGreen;
            this.buttonAddPlayer.FlatAppearance.BorderSize = 0;
            this.buttonAddPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.UseVisualStyleBackColor = false;
            this.buttonAddPlayer.Click += new System.EventHandler(this.addUser_Click);
            // 
            // usernameLabel
            // 
            resources.ApplyResources(this.usernameLabel, "usernameLabel");
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usernameLabel.ForeColor = System.Drawing.Color.White;
            this.usernameLabel.Name = "usernameLabel";
            // 
            // namesLabel
            // 
            resources.ApplyResources(this.namesLabel, "namesLabel");
            this.namesLabel.BackColor = System.Drawing.Color.Transparent;
            this.namesLabel.ForeColor = System.Drawing.Color.White;
            this.namesLabel.Name = "namesLabel";
            // 
            // age
            // 
            resources.ApplyResources(this.age, "age");
            this.age.Name = "age";
            // 
            // ageLabel
            // 
            resources.ApplyResources(this.ageLabel, "ageLabel");
            this.ageLabel.BackColor = System.Drawing.Color.Transparent;
            this.ageLabel.ForeColor = System.Drawing.Color.White;
            this.ageLabel.Name = "ageLabel";
            // 
            // playersList
            // 
            resources.ApplyResources(this.playersList, "playersList");
            this.playersList.FormattingEnabled = true;
            this.playersList.Name = "playersList";
            // 
            // menuStrip1
            // 
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeLanguageToolStripMenuItem,
            this.showPlayersToolstripMenuItem,
            this.showGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Name = "menuStrip1";
            // 
            // changeLanguageToolStripMenuItem
            // 
            resources.ApplyResources(this.changeLanguageToolStripMenuItem, "changeLanguageToolStripMenuItem");
            this.changeLanguageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.bulgarianToolStripMenuItem});
            this.changeLanguageToolStripMenuItem.Name = "changeLanguageToolStripMenuItem";
            // 
            // englishToolStripMenuItem
            // 
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // bulgarianToolStripMenuItem
            // 
            resources.ApplyResources(this.bulgarianToolStripMenuItem, "bulgarianToolStripMenuItem");
            this.bulgarianToolStripMenuItem.Name = "bulgarianToolStripMenuItem";
            this.bulgarianToolStripMenuItem.Click += new System.EventHandler(this.bulgarianToolStripMenuItem_Click);
            // 
            // showPlayersToolstripMenuItem
            // 
            resources.ApplyResources(this.showPlayersToolstripMenuItem, "showPlayersToolstripMenuItem");
            this.showPlayersToolstripMenuItem.Name = "showPlayersToolstripMenuItem";
            this.showPlayersToolstripMenuItem.Click += new System.EventHandler(this.showPlayersToolStripMenuItem_Click);
            // 
            // showGameToolStripMenuItem
            // 
            resources.ApplyResources(this.showGameToolStripMenuItem, "showGameToolStripMenuItem");
            this.showGameToolStripMenuItem.Name = "showGameToolStripMenuItem";
            this.showGameToolStripMenuItem.Click += new System.EventHandler(this.showGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            resources.ApplyResources(this.exitToolStripMenuItem, "exitToolStripMenuItem");
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // gameBoard
            // 
            resources.ApplyResources(this.gameBoard, "gameBoard");
            this.gameBoard.BackColor = System.Drawing.Color.ForestGreen;
            this.gameBoard.Name = "gameBoard";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Casino_Registration.Properties.Resources.casino_fon;
            this.Controls.Add(this.gameBoard);
            this.Controls.Add(this.playersList);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.age);
            this.Controls.Add(this.namesLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.names);
            this.Controls.Add(this.username);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox names;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label namesLabel;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.ListBox playersList;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem changeLanguageToolStripMenuItem;
        private ToolStripMenuItem englishToolStripMenuItem;
        private ToolStripMenuItem bulgarianToolStripMenuItem;
        private ToolStripMenuItem showPlayersToolstripMenuItem;
        private ToolStripMenuItem showGameToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Panel gameBoard;
    }
}

