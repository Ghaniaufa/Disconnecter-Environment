using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Pipes;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using System.Windows.Input;

namespace Disconnecter_Environment
{
    public partial class Data_Master : Form
    {
        public Data_Master()
        {
            InitializeComponent();
        }


        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void Data_Master_Load(object sender, EventArgs e)
        {

        }

        private void dataProdiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Data_Prodi fm = new Form_Data_Prodi();
            fm.Show();
            this.Hide();
        }

        private void dataMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Mahasiswa fo = new Data_Mahasiswa();
            fo.Show();
            this.Hide();
        }

        private void dataStatusMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Status_Mahasiwa fr = new Data_Status_Mahasiwa();
            fr.Show();
            this.Hide();
        }
    }
}
