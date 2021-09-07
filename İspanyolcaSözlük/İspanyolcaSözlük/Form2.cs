using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace İspanyolcaSözlük
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbSozlukDataSet1.TBLKelimeler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBLKelimelerTableAdapter.Fill(this.dbSozlukDataSet1.TBLKelimeler);

        }
        SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-HQL8VB3;Initial Catalog=DbSozluk;Integrated Security=True");
        private void button1_Click(object sender, EventArgs e)
        {
            bagla.Open();
            SqlCommand komut = new SqlCommand("insert into TBLKelimeler (İspanyolca,Türkce) values (@p1,@p2)", bagla);
            komut.Parameters.AddWithValue("@p1",mskIspanyolca.Text);
            komut.Parameters.AddWithValue("@p2", mskTurkce.Text);
            komut.ExecuteNonQuery();
            bagla.Close();
            this.tBLKelimelerTableAdapter.Fill(this.dbSozlukDataSet1.TBLKelimeler);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();
        }
    }
}
