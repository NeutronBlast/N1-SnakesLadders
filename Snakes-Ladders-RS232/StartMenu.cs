using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Snakes_Ladders_RS232
{
    public partial class StartMenu : Form
    {
        private int id;
        private String puerto;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {

        }

        private void lookupPorts_Click(object sender, EventArgs e)
        {
            portsComboBox.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            portsComboBox.Items.AddRange(ports);
            portsComboBox.Enabled = true;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            player1_Button.Enabled = true;
            player2_Button.Enabled = true;
            player3_Button.Enabled = true;
            player4_Button.Enabled = true;
            selectPlayer_Label.Visible = true;
        }

        private void portsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            startGame.Enabled = true;
            puerto = portsComboBox.Text;
        }

        private void player1_Button_Click(object sender, EventArgs e)
        {
            this.id = 1;
            player2_Button.Enabled = false;
            player3_Button.Enabled = false;
            player4_Button.Enabled = false;
            selectPlayer_Label.Text = "Jugador 1 seleccionado";
            Game();
            this.WindowState = FormWindowState.Minimized;
        }

        private void player2_Button_Click(object sender, EventArgs e)
        {
            this.id = 2;
            player1_Button.Enabled = false;
            player3_Button.Enabled = false;
            player4_Button.Enabled = false;
            selectPlayer_Label.Text = "Jugador 2 seleccionado";
            Game();
        }

        private void player3_Button_Click(object sender, EventArgs e)
        {
            this.id = 3;
            player1_Button.Enabled = false;
            player2_Button.Enabled = false;
            player4_Button.Enabled = false;
            selectPlayer_Label.Text = "Jugador 3 seleccionado";
            Game();
            this.WindowState = FormWindowState.Minimized;
        }

        private void player4_Button_Click(object sender, EventArgs e)
        {
            this.id = 4;
            player1_Button.Enabled = false;
            player2_Button.Enabled = false;
            player3_Button.Enabled = false;
            selectPlayer_Label.Text = "Jugador 4 seleccionado";
            Game();
            this.WindowState = FormWindowState.Minimized;
        }

        private void quitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Game()
        {
            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void ThreadStart()
        {
            System.Diagnostics.Trace.WriteLine("whatever");
            Form game = new Game(this.id, this.puerto);
            Application.Run(game); // <-- other form started on its own UI thread
        }
    }
}
