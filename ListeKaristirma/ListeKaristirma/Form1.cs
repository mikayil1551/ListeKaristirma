using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListeKaristirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim()!=string.Empty)
            {
                string isim = string.Format("{0}-{1}",listBox1.Items.Count+1,textBox1.Text.Trim());
          
                if (listBox1.Items.Contains(isim) == true)
                {
                    MessageBox.Show("Isim girilmisdir.Lutfen baska isim giriniz:)");
                    textBox1.Clear();
                    textBox1.Focus();
                }
                else
                {
                    listBox1.Items.Add(isim);
                    textBox1.Clear();
                    textBox1.Focus();
                }
            }
           
            
        }

        private void btnKaristir_Click(object sender, EventArgs e)
        {
            string[] isimler = new string[listBox1.Items.Count];
            Random rnd = new Random();
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                int sayi = rnd.Next(0, listBox1.Items.Count);
                string rastgele = listBox1.Items[sayi].ToString();

                if (isimler.Contains(rastgele)==false)
                {
                    isimler[i] = rastgele;

                }
                else
                {
                    i--;
                }
            }
            listBox1.Items.Clear();
            foreach (string item in isimler)
            {
                listBox1.Items.Add(item);

            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult sonuc =  MessageBox.Show("Silmek istediginizden emin misiniz", "Silme Formu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (sonuc==DialogResult.Yes)
            {
                string[] silinecekler = new string[listBox1.SelectedItems.Count];
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    silinecekler[i] = (string)listBox1.SelectedItems[i];
                }
                foreach (string item in silinecekler)
                {
                    listBox1.Items.Remove(item);

                }
            }
           
            
        }

        private void btnEkle_MouseHover(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.Red;
        }

        private void btnEkle_MouseLeave(object sender, EventArgs e)
        {
            btnEkle.BackColor = Color.White;
        }

        private void btnSil_MouseHover(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.Red;
        }

        private void btnSil_MouseLeave(object sender, EventArgs e)
        {
            btnSil.BackColor = Color.White;
        }

        private void btnKaristir_MouseHover(object sender, EventArgs e)
        {
            btnKaristir.BackColor = Color.Red;
        }

        private void btnKaristir_MouseLeave(object sender, EventArgs e)
        {
            btnKaristir.BackColor = Color.White;
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            DialogResult sonuc = MessageBox.Show("Silmek istediginizden emin misiniz", "Silme Formu",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (sonuc == DialogResult.Yes)
            {
                string[] silinecekler = new string[listBox1.SelectedItems.Count];
                for (int i = 0; i < listBox1.SelectedItems.Count; i++)
                {
                    silinecekler[i] = (string)listBox1.SelectedItems[i];
                }
                foreach (string item in silinecekler)
                {
                    listBox1.Items.Remove(item);

                }
            }
        }
    }
}
