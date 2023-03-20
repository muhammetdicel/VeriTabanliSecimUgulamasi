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


namespace VeriTabanlıSecimUgulamasi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection bgl = new SqlConnection(@"Data Source=DESKTOP-TCEOMIL\SQLEXPRESS;Initial Catalog=DbSecim;Integrated Security=True");
        private void BtnOyGiris_Click(object sender, EventArgs e)
        {
            bgl.Open();
            SqlCommand komut = new SqlCommand("insert into TBLILCE (ILCEAD,APARTI,BPARTI,CPARTI,DPARTI,EPARTI) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl);
            komut.Parameters.AddWithValue("@p1", TxtIlce.Text);
            komut.Parameters.AddWithValue("@p2", TxtA.Text);
            komut.Parameters.AddWithValue("@p3", TxtB.Text);
            komut.Parameters.AddWithValue("@p4", TxtC.Text);
            komut.Parameters.AddWithValue("@p5", TxtD.Text);
            komut.Parameters.AddWithValue("@p6", TxtE.Text);
            komut.ExecuteNonQuery();
            bgl.Close();
            MessageBox.Show("Kayıt tamamlandı");
        }

        private void BtnGrafik_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.Show();
        }
    }
}
