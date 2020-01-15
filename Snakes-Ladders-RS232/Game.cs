using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using System.Windows.Forms;

namespace Snakes_Ladders_RS232
{
    public partial class Game : Form
    {
        private int ID;
        private bool observador;
        private int tablero_type;
        private Board t;
        private int sentido;
        private int cont = 0;

        private int j1 = 0;
        private int j2 = 0;
        private int j3 = 0;
        private int j4 = 0;

        Connector connector = new Connector();
        String TramaIn;
        String TramaOut;
        public Game()
        {
            InitializeComponent();
        }

        public Game(int id, String port)
        {
            InitializeComponent();
            this.ID = id;
            this.tablero_type = 0;
            this.sentido = 0;
            /*if (this.ID == 1)
            {
                this.Mensaje.Text = "Selecciona un tablero";
                this.Mensaje.Visible = true;
                this.Dado.Enabled = true;
            }*/


        }
        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
