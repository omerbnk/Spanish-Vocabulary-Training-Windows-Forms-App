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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        int secilen;
        int dogru = 0;
        int sure = 90;
        int x;
        int rekor;
        SqlConnection bagla = new SqlConnection(@"Data Source=DESKTOP-HQL8VB3;Initial Catalog=DbSozluk;Integrated Security=True");

        void kelime()
        {
            bagla.Open();
            SqlCommand komut2 = new SqlCommand("Select COUNT(*) from TBLKelimeler", bagla);
            SqlDataReader rd2 = komut2.ExecuteReader();
            while (rd2.Read())
            {
                x = Int32.Parse(rd2[0].ToString()) ;
            }
            secilen = rast.Next(1, x+1);
            rd2.Close();

            SqlCommand komut = new SqlCommand("select * from TBLKelimeler where ID=@p1", bagla);
            komut.Parameters.AddWithValue("@p1", secilen);
            rd2 = komut.ExecuteReader();
            while (rd2.Read())
            {
                mskIspanyolca.Text = rd2[1].ToString();
                lblCevap.Text = rd2[2].ToString();
           
            }
            bagla.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            kelime();
            timer1.Start();
        }

        // ctrl+k+d

        private void timer1_Tick(object sender, EventArgs e)
        {
            sure--;
            lblSure.Text = sure.ToString();
            if (sure == 0)
            {
                mskIspanyolca.Enabled = false;
                mskTurkce.Enabled = false;
                timer1.Stop();
            }
        }


        private void mskTurkce_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            { 
                if (mskTurkce.Text == lblCevap.Text)
                {                
                    dogru++;
                    lblKelime.Text = dogru.ToString();
                    kelime();
                    mskTurkce.Clear();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tekrarBaslat();
        }
        void tekrarBaslat()
        {
            mskIspanyolca.Enabled = true;
            mskTurkce.Enabled = true;
            sure = 90;
            timer1.Start();
            dogru = 0;
            kelime();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    
       
    }
}
