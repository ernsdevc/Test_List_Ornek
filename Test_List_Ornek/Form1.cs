using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_List_Ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele1_Click(object sender, EventArgs e)
        {
            List<string> kisiler = new List<string>();
            kisiler.Add("Mazhar");
            kisiler.Add("Ruhsar");
            kisiler.Add("Menkıbe");
            kisiler.Add("Müfit");
            kisiler.Add("Reyhan");
            kisiler.Add("Firdes");

            kisiler.Remove("Müfit");

            foreach (string kisi in kisiler)
            {
                listBox1.Items.Add(kisi);
            }
        }

        private void btnListele2_Click(object sender, EventArgs e)
        {
            List<int> sayilar = new List<int>();
            sayilar.Add(45);
            sayilar.Add(74);
            sayilar.Add(25);
            sayilar.Add(33);
            sayilar.Add(22);
            sayilar.Add(15);
            sayilar.Add(14);

            foreach (int sayi in sayilar)
            {
                if (sayi % 5 == 0)
                {
                    listBox2.Items.Add(sayi);
                }
            }

            if (!String.IsNullOrEmpty(txtSayi.Text))
            {
                if (sayilar.Contains(Convert.ToInt32(txtSayi.Text)))
                {
                    MessageBox.Show("Bu sayı var");
                }
                else
                {
                    MessageBox.Show("Bu sayı yok");
                }
            }
        }

        private void txtSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnListele3_Click(object sender, EventArgs e)
        {
            List<Kisi> kisiler = new List<Kisi>();
            kisiler.Add(new Kisi() { Ad = "Ali", Soyad = "Çınar", Meslek = "Öğretmen"});

            foreach (Kisi kisi in kisiler)
            {
                listBox3.Items.Add(kisi.Ad + ' ' + kisi.Soyad + ' ' + kisi.Meslek);
            }
        }
    }
}
