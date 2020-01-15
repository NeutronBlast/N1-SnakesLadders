using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO.Ports;
using System.Windows.Forms;

namespace Snakes_Ladders_RS232
{
    public partial class Game : Form
    {
        private int ID;
        private int tablero_type;
        private Board t;
        private int sentido;
        private int cont = 0;

        private int j1 = 0;
        private int j2 = 0;
        private int j3 = 0;
        private int j4 = 0;

        private SerialPort serialPort1 = new SerialPort();

        private int[] boards = { 1, 2, 3, 4, 5, 6 };

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
            if (this.ID == 1)
            {
                this.boardComboBox.Visible = true;
                this.boardComboBox.Enabled = true;
                this.sb_label.Visible = true;
                boardComboBox.Items.Add(boards[0]);
                boardComboBox.Items.Add(boards[1]);
                boardComboBox.Items.Add(boards[2]);
                boardComboBox.Items.Add(boards[3]);
                boardComboBox.Items.Add(boards[4]);
                boardComboBox.Items.Add(boards[5]);
            }

            try
            {
                serialPort1.PortName = port;
                serialPort1.BaudRate = Convert.ToInt32("9600");
                serialPort1.DataBits = Convert.ToInt32("8");
                serialPort1.Open();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        private void Game_Load(object sender, EventArgs e)
        {
            connector.USID = JugadorBit(this.ID);
            //System.Diagnostics.Trace.Write("id = ");
            //System.Diagnostics.Trace.WriteLine(this.ID);
        }

        private void boardComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (this.tablero_type == 0)
            {
                int currentBoard = Int32.Parse(boardComboBox.Text);
                DecidirTablero(currentBoard);
                EnviarTablero(currentBoard);
            }
            boardComboBox.Enabled = false;
            boardComboBox.Visible = false;
            sb_label.Visible = false;
            this.rollDice.Enabled = true;
        }

        private void rollDice_Click(object sender, EventArgs e)
        {
            this.rollDice.Enabled = false;
            int d = LanzarDado();

            //if (this.cont == 3)
                //{
                    if (d == 6)
                    {
                        this.cont = 0;
                        Moverse(d, this.ID);
                        EnviarMovimiento(d);
                    }
                    else
                    {
                        this.cont = 0;
                        Moverse(d, this.ID);
                        EnviarMovimiento(d);
                        EnviarTurno();
                    }

                //}
                /*else
                {
                    Moverse(d, this.ID);
                    EnviarMovimiento(d);
                }*/

            
        }

        private int LanzarDado()
        {
            Random i = new Random();
            int n = i.Next(1, 7);
            if (n == 7) n = 6;
            this.DadoL.Text = String.Concat(n);
            return n;
        }

        private void DecidirTablero(int i)
        {
            this.t = new Board(i);
            this.tablero_type = i;
            string path = Application.StartupPath + "\\Assets\\";
            switch (i)
            {
                case 1:
                    this.board_picture_box.Image = Image.FromFile(path+"board_1.jpg");
                    break;
                case 2:
                    this.board_picture_box.Image = Image.FromFile(path + "board_2.jpg");
                    break;
                case 3:
                    this.board_picture_box.Image = Image.FromFile(path + "board_3.jpg");
                    break;
                case 4:
                    this.board_picture_box.Image = Image.FromFile(path + "board_4.jpg");
                    break;
                case 5:
                    this.board_picture_box.Image = Image.FromFile(path + "board_5.jpg");
                    break;
                case 6:
                    this.board_picture_box.Image = Image.FromFile(path + "board_6.jpg");
                    break;
            }
        }

        public void Moverse(int i, int id)
        {
            if (id == 1)
            {
                this.j1 += i;
                if (this.j1 > 100) this.j1 = 100;

                this.Score1.Text = String.Concat(this.j1);

                if (t.CasillaEspecial(this.j1))
                {
                    SwitchSentido();
                    this.sb_label.Text = "CAMBIO EL SENTIDO";
                    this.sb_label.Visible = true;
                }

                while (t.CasillaTrampa(this.j1))
                {
                    this.sb_label.Text = "CASILLA ESPECIAL!";
                    this.sb_label.Visible = true;
                    Thread.Sleep(1000);
                    this.j1 = t.ObteberDestino(this.j1);
                    this.Score1.Text = String.Concat(this.j1);
                    if (t.CasillaEspecial(this.j1))
                    {
                        SwitchSentido();
                        this.sb_label.Text = "CAMBIO EL SENTIDO";
                        this.sb_label.Visible = true;
                    }
                }

                if (this.j1 == 100)
                    Ganador(id);
            }
            else if (id == 2)
            {
                this.j2 += i;
                if (this.j2 > 100)
                    this.j2 = 100;

                this.Score2.Text = String.Concat(this.j2);

                if (t.CasillaEspecial(this.j2))
                {
                    SwitchSentido();
                    this.sb_label.Text = "CAMBIO EL SENTIDO";
                }

                while (t.CasillaTrampa(this.j2))
                {
                    this.sb_label.Text = "CASILLA ESPECIAL!";
                    this.j2 = t.ObteberDestino(this.j2);
                    this.Score2.Text = String.Concat(this.j2);
                    if (t.CasillaEspecial(this.j2))
                    {
                        SwitchSentido();
                        this.sb_label.Text = "CAMBIO EL SENTIDO";
                    }
                }

                if (this.j2 == 100)
                    Ganador(id);
            }
            else if (id == 3)
            {
                this.j3 += i;

                if (this.j3 > 100)
                    this.j3 = 100;

                this.Score3.Text = String.Concat(this.j3);

                if (t.CasillaEspecial(this.j3))
                {
                    SwitchSentido();
                    this.sb_label.Text = "CAMBIO EL SENTIDO";
                }

                while (t.CasillaTrampa(this.j3))
                {
                    this.sb_label.Text = "CASILLA ESPECIAL!";
                    this.j3 = t.ObteberDestino(this.j3);
                    this.Score3.Text = String.Concat(this.j3);
                    if (t.CasillaEspecial(this.j3))
                    {
                        SwitchSentido();
                        this.sb_label.Text = "CAMBIO EL SENTIDO";
                    }
                }

                if (this.j3 == 100)
                    Ganador(id);
            }
            else
            {
                this.j4 += i;

                if (this.j4 > 100)
                    this.j4 = 100;

                this.Score4.Text = String.Concat(this.j4);

                if (t.CasillaEspecial(this.j4))
                {
                    SwitchSentido();
                    this.sb_label.Text = "CAMBIO EL SENTIDO";
                }

                while (t.CasillaTrampa(this.j4))
                {
                    this.sb_label.Text = "CASILLA ESPECIAL!";
                    this.j4 = t.ObteberDestino(this.j4);
                    this.Score4.Text = String.Concat(this.j4);
                    if (t.CasillaEspecial(this.j4))
                    {
                        SwitchSentido();
                        this.sb_label.Text = "CAMBIO EL SENTIDO";
                    }
                }

                if (this.j4 == 100)
                    Ganador(id);
            }
            this.sb_label.Visible = false;
        }

        public void SwitchSentido()
        {
            if (this.sentido == 0)
                this.sentido = 1;
            else
                this.sentido = 0;
        }

        public int NextPlayer()
        {
            switch (this.ID)
            {
                case 1:
                    if (this.sentido == 0)
                        return 2;
                    if (this.sentido == 1)
                        return 4;
                    break;
                case 2:
                    if (this.sentido == 0)
                        return 3;
                    if (this.sentido == 1)
                        return 1;
                    break;
                case 3:
                    if (this.sentido == 0)
                        return 4;
                    if (this.sentido == 1)
                        return 2;
                    break;
                case 4:
                    if (this.sentido == 0)
                        return 1;
                    if (this.sentido == 1)
                        return 3;
                    break;
            }
            System.Diagnostics.Trace.Write("id = ");
            System.Diagnostics.Trace.WriteLine(this.ID);

            return 0;
        }

        public void Ganador(int id)
        {
            MessageBox.Show(String.Concat("El ganador es el jugador ", id), "Winner", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Windows.Forms.Application.Exit();
        }

        public String JugadorBit(int i)
        {
            if (i == 1)
                return "00";
            else if (i == 2)
                return "01";
            else if (i == 3)
                return "10";
            else
                return "11";
        }

        public String DadoBit(int i)
        {
            if (i == 1)
                return "000";
            else if (i == 2)
                return "001";
            else if (i == 3)
                return "010";
            else if (i == 4)
                return "011";
            else if (i == 5)
                return "100";
            else if (i == 6)
                return "101";
            else
                return "111";
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            TramaIn = serialPort1.ReadLine();
            this.Invoke(new EventHandler(ShowData));
        }

        private void ShowData(object sender, EventArgs e)
        {
            System.Diagnostics.Trace.Write("yo hello receiving data here");
            connector.Control(TramaIn);
            if (TramaIn.Length >= 16)
            {
                switch (connector.Accion())
                {
                    case 1:                             // recibir tablero
                        if (this.ID == 1)
                        {
                            this.sb_label.Text = "Tu Turno";
                            this.rollDice.Enabled = true;
                        }
                        else
                        {
                            Repetir();
                            DecidirTablero(connector.Dado());
                        }
                        break;

                    case 2:
                        if (connector.JugadorO() == this.ID)
                        {
                            Thread.Sleep(200);
                            if (connector.Dado() == 6)
                            {
                                this.cont += 1;
                                if (this.cont == 3)
                                    EnviarTurno();
                                else
                                    this.rollDice.Enabled = true;
                            }
                            else
                            {
                                this.cont = 0;
                                EnviarTurno();
                            }
                        }
                        else
                        {
                            Repetir();
                            Moverse(connector.Dado(), connector.JugadorO());
                        }
                        break;

                    case 3:
                        break;

                    case 4:
                        if (connector.JugadorD() == this.ID)
                        {
                            this.sb_label.Text = "Tu turno";
                            this.sb_label.Visible = true;
                            this.rollDice.Enabled = true;
                            //else
                                //EnviarTurno();
                        }
                        else
                        {
                            Repetir();
                        }
                        break;

                    case 5:
                        break;
                }
            }
        }

        private void Repetir()
        {
            TramaOut = TramaIn;
            serialPort1.WriteLine(TramaOut);
        }

        private void EnviarTablero(int i)
        {
            TramaOut = String.Concat("00", "00", "000", DadoBit(i), 0, "00000");
            serialPort1.WriteLine(TramaOut);
        }

        private void EnviarMovimiento(int d)
        {
            //System.Diagnostics.Trace.WriteLine("send move");
            String player = JugadorBit(this.ID);
            TramaOut = String.Concat(player, player, "001", DadoBit(d), 0, "00000");
            serialPort1.WriteLine(TramaOut);
        }

        private void EnviarTurno()
        {
            System.Diagnostics.Trace.WriteLine("Enviar turno");
            TramaOut = String.Concat(JugadorBit(this.ID), JugadorBit(NextPlayer()), "011", "000", 0, "00000");
            serialPort1.WriteLine(TramaOut);
        }

    }
}
