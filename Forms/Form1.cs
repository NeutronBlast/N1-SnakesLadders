using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace Escalera
{
    public partial class Form1 : Form
    {
        private int id;
        private String puerto;
        private bool observador;
        private int dificultad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Puertos_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Connect_Click(object sender, EventArgs e)
        {

        }

        private void BJugar_Click(object sender, EventArgs e)
        {

        }

        private void BObservar_Click(object sender, EventArgs e)
        {

        }

        private void BJugador1_Click(object sender, EventArgs e)
        {

        }

        private void BJugador2_Click(object sender, EventArgs e)
        {

        }

        private void BJugador3_Click(object sender, EventArgs e)
        {

        }

        private void BJugador4_Click(object sender, EventArgs e)
        {

        }

        private void Partida()
        {
            var thread = new Thread(ThreadStart);
            thread.TrySetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void ThreadStart()
        {
            Application.Run(new Forms.Juego(this.id, this.observador, this.puerto, this.dificultad)); // <-- other form started on its own UI thread
        }

        private void DificultadList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bConnect_Click(object sender, EventArgs e)
        {
            ListaPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            ListaPorts.Items.AddRange(ports);
            ListaPorts.Enabled = true;
        }

        private void ListaPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            bJugar.Enabled = true;
            bObservar.Enabled = true;
            puerto = ListaPorts.Text;
        }

        private void bJugar_Click_1(object sender, EventArgs e)
        {
            this.observador = false;
            bJugador1.Visible = true;
            bJugador1.Enabled = true;
            bJugador2.Visible = true;
            bJugador3.Visible = true;
            bJugador4.Visible = true;
            select_player_label.Visible = true;
        }

        private void bObservar_Click_1(object sender, EventArgs e)
        {
            this.observador = true;
            bJugador1.Visible = true;
            bJugador1.Enabled = false;
            bJugador2.Visible = true;
            bJugador3.Visible = true;
            bJugador4.Visible = true;
        }

        private void bJugador1_Click_1(object sender, EventArgs e)
        {
            this.id = 1;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            bObservar.Enabled = false;
            difficulty_label.Visible = true;

            DificultadList.Items.Clear();
            string[] lista = { "PruebaUno", "PruebaDos" };
            DificultadList.Items.AddRange(lista);
            DificultadList.Enabled = true;
            DificultadList.Visible = true;
        }

        private void bJugador2_Click_1(object sender, EventArgs e)
        {
            this.id = 2;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            Partida();
            this.WindowState = FormWindowState.Minimized;
            //System.Windows.Forms.Application.Exit();
        }

        private void bJugador3_Click_1(object sender, EventArgs e)
        {
            this.id = 3;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            Partida();
            System.Windows.Forms.Application.Exit();
        }

        private void bJugador4_Click_1(object sender, EventArgs e)
        {
            this.id = 4;
            bJugador1.Enabled = false;
            bJugador2.Enabled = false;
            bJugador3.Enabled = false;
            bJugador4.Enabled = false;
            Partida();
            System.Windows.Forms.Application.Exit();
        }

        private void DificultadList_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (DificultadList.Text == "PruebaUno")
                dificultad = 0;
            else
                dificultad = 1;
            Partida();
            this.WindowState = FormWindowState.Minimized;
            //System.Windows.Forms.Application.Exit();
        }

        private void quit_Game_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
