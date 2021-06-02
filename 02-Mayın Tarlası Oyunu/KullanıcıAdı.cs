using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Mayın_Tarlası_Oyunu
{
    public partial class KullanıcıAdı : Form
    {
        public KullanıcıAdı()
        {
            InitializeComponent();
        }

        private void KullanıcıAdı_Load(object sender, EventArgs e)
        {

        }
        int sayID=0;

        private void btnDevamEt_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
