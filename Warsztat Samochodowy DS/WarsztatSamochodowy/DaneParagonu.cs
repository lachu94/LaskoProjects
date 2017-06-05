using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarsztatSamochodowy.Models;

namespace WarsztatSamochodowy
{
    public partial class DaneParagonu : Form
    {
        int index = 1;
        double razem = 0;
        public DaneParagonu()
        {
            InitializeComponent();
        }

        private void DaneParagonu_Load(object sender, EventArgs e)
        {
            paragonBindingSource.DataSource = new List<Paragon>();

        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtNazwa.Text) && !string.IsNullOrEmpty(txtCena.Text))
            {
                Paragon obj = new Paragon()
                {
                    id = index++,
                    nazwaProduktu = txtNazwa.Text,
                    cena = Convert.ToDouble(txtCena.Text),
                    ilosc = Convert.ToInt32(txtIlosc.Text)

                };

                razem += obj.ilosc * obj.cena;
                paragonBindingSource.Add(obj);
                paragonBindingSource.MoveLast();
                txtNazwa.Text = string.Empty;
                txtIlosc.Text = string.Empty;
                txtCena.Text = string.Empty;
            }

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            Paragon obj = paragonBindingSource.Current as Paragon;
            if (obj != null)
            {
                razem -= obj.cena * obj.ilosc;
            }
            paragonBindingSource.RemoveCurrent();
        }



        private void btbDrukuj_Click(object sender, EventArgs e)
        {
            //using (Wydruk frm = new Wydruk(paragonBindingSource.DataSource as List<Paragon>, DateTime.Now.ToString("dd/MM/yyyy"), string.Format("{0:0.00} PLN", Convert.ToDouble(razem))))
            //{
            //    frm.ShowDialog();
            //}
            Wydruk frm = new Wydruk();
                frm.ShowDialog();
        }
    }
}
