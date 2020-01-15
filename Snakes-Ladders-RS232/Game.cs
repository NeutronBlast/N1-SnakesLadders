using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snakes_Ladders_RS232
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        public Game(int id, String port)
        {
            InitializeComponent();
        }
        private void Game_Load(object sender, EventArgs e)
        {

        }
    }
}
