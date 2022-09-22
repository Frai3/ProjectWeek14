using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWeek14
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        public static int no { get; set; }
        public static DateTime tgl { get; set; } 

        private void btnMakanan_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(DateTime.Now.ToString("dd/MM/yyyy"));

            Makanan makanan = new Makanan();
            makanan.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            no = Convert.ToInt32(textBox1.Text);
            tgl = DateTime.Now;
        }
    }
}
