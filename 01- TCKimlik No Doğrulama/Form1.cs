using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01__TCKimlik_No_Doğrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            TCKimlikNoDoğrulamaServisi.KPSPublic kps = new TCKimlikNoDoğrulamaServisi.KPSPublic();
            bool kontrol1 = kps.TCKimlikNoDogrula(long.Parse(txtTcKimlikNo.Text), txtIsim.Text.ToUpper(), txtSoyisim.Text.ToUpper(), Convert.ToInt32(txtDogumYili.Text));

            if (kontrol1)
            {
                MessageBox.Show("Bilgileriniz doğrulandı...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz doğrulanamadı...", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
