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
    public partial class Noodle : Form
    {
        public Noodle()
        {
            InitializeComponent();
        }
        
        int count = 0;
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=G:\\New folder\\S7\\Visprog\\ProjectWeek14database.mdb");

        DateTime tgl = HomeScreen.tgl;
        int noMeja = HomeScreen.no;

        private void btnMieRebus_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(tgl.ToString("dd/MM/yyyy") + " " + noMeja);
            

            try
            {
                connection.Open();

                string query = "SELECT noMeja FROM transaksi WHERE noMeja = @noMeja";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@noMeja", noMeja);
                OleDbDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    textBox1.Text = dataReader.GetValue(1).ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnMieGoreng_Click(object sender, EventArgs e)
        {

        }
    }
}
