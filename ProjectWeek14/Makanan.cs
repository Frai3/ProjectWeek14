using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectWeek14
{
    public partial class Makanan : Form
    {
        public Makanan()
        {
            InitializeComponent();
        }

        private void Makanan_Load(object sender, EventArgs e)
        {

        }

        private void btnMie_Click(object sender, EventArgs e)
        {
            Noodle mie = new Noodle();
            mie.Show();
        }
    }
}
