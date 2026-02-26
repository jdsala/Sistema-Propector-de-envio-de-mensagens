using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace ProjetoMarketing
{
    public partial class FrmMensagem : Form
    {
        public FrmMensagem()
        {
            InitializeComponent();
        }

        private void FrmMensagem_Load(object sender, EventArgs e)
        {
            //inicia o timer
             timer1.Start();

            //intervalo para o tick de 10 segundos
             timer1.Interval = 3000;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        { 
            this.Close();
        }
    }
}
