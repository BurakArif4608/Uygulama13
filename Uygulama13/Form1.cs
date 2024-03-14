using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uygulama13
{
    public partial class Form1 : Form
    {
        List<Öğrenciler> ogrencilerList = new List<Öğrenciler>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNesneEkle_Click(object sender, EventArgs e)
        {
            string cinsiyet;
            Öğrenciler ogrenci = new Öğrenciler();
            ogrenci.Numara= int.Parse(txtOgrenciNo.Text);
            ogrenci.AdSoyad = txtAdiSoyadi.Text;
            if (radioButtonBay.Checked) ogrenci.Cinsiyet = true;
            else ogrenci.Cinsiyet= false;
            ogrencilerList.Add(ogrenci);
            lbNesne.Items.Clear();
            foreach (var item in ogrencilerList)
            {
                if (radioButtonBay.Checked) cinsiyet = "Bay";
                
                else cinsiyet = "Bayan";
                lbNesne.Items.Add(item.Numara +" "+item.AdSoyad +" "+cinsiyet);
                
            }
        }
    }
}
